using System;
using System.Windows.Forms;

namespace ValSystem.Controls
{
    public partial class NumericTextBox : TextBox
    {
        protected string mask;
        protected decimal value;
        protected bool decimais;
        protected EventHandler textChangedEvent;

        public NumericTextBox()
        {
            InitializeComponent();

            this.TextAlign = HorizontalAlignment.Right;

            this.KeyPress += new KeyPressEventHandler( this.NumericTextBox_KeyPress );

            this.textChangedEvent = new EventHandler( this.NumericTextBox_TextChanged );

            this.TextChanged += this.textChangedEvent; ;

            this.Enter += new EventHandler( this.NumericTextBox_Enter );

            this.Value = 0;
            this.decimais = false;
        }

        protected override void OnPaint( PaintEventArgs pe )
        {
            base.OnPaint( pe );
        }

        private void NumericTextBox_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( char.IsControl( e.KeyChar ) )
            {
                if ( e.KeyChar == ( char )Keys.Back )
                {
                    if ( this.Text.IndexOf( "," ) >= 0 && this.SelectionStart - 1 == this.Text.IndexOf( "," ) )
                    {
                        this.SelectionStart -= 1;

                        this.decimais = false;

                        e.Handled = true;
                    }
                }
            }
            else
            {
                if ( char.IsDigit( e.KeyChar ) || char.Equals( e.KeyChar, '.' ) || char.Equals( e.KeyChar, ',' ) )
                {
                    if ( char.IsDigit( e.KeyChar ) )
                    {
                        if ( this.decimais )
                        {
                            if ( this.SelectionStart == this.Text.Length )
                            {
                                e.Handled = true;
                            }
                        }
                        else
                        {
                            if ( string.Format( "{0:" + this.Mask + "}", this.Value ).Length >= this.Mask.Length && this.SelectionLength != this.Mask.Length )
                            {
                                e.Handled = true;
                            }
                        }
                    }
                    else if ( this.Text.Contains( "," ) )
                    {
                        if ( char.Equals( e.KeyChar, '.' ) || char.Equals( e.KeyChar, ',' ) )
                        {
                            if ( this.decimais )
                            {
                                this.SelectionStart = this.Text.IndexOf( "," );

                                this.decimais = false;
                            }
                            else
                            {
                                this.SelectionStart = this.Text.IndexOf( "," ) + 1;

                                this.decimais = true;
                            }

                            e.Handled = true;
                        }
                        else if ( char.Equals( e.KeyChar, '\b' ) )
                        {
                            if ( this.SelectionStart == this.Text.IndexOf( "," ) + 1 )
                            {
                                this.SelectionStart = this.Text.IndexOf( "," );

                                this.decimais = false;

                                e.Handled = true;
                            }
                        }
                    }
                }
                else
                {
                    e.Handled = true;	// Ignora a tecla pressionada
                }
            }
        }

        private void NumericTextBox_TextChanged( object sender, EventArgs e )
        {
            this.TextChanged -= this.textChangedEvent;

            if ( this.Text == string.Empty || this.Text == "," || this.Text == "." )
            {
                this.Text = "0";
            }

            if ( "0123456789,".IndexOf( this.Text.Substring( 0, 1 ) ) >= 0 )
            {
                this.value = Convert.ToDecimal( this.Text.Replace( ".", null ) );

                if ( this.decimais )	// Se editando a parte decimal o cursor tem que avançar
                {
                    int pos = this.SelectionStart;

                    this.Text = string.Format( "{0:" + this.Mask + "}", this.value );

                    this.SelectionStart = pos;
                }
                else
                {
                    this.Text = string.Format( "{0:" + this.Mask + "}", this.value );

                    int pos = this.Text.IndexOf( "," );

                    if ( pos >= 0 )
                    {
                        this.SelectionStart = pos;
                    }
                    else
                    {
                        this.SelectionStart = this.Text.Length;
                    }
                }
            }

            this.TextChanged += this.textChangedEvent;
        }

        private void NumericTextBox_Enter( object sender, EventArgs e )
        {
            this.SelectAll();

            this.decimais = false;
        }

        public string Mask
        {
            get
            {
                return this.mask;
            }
            set
            {
                this.mask = value;
            }
        }

        public decimal Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;

                this.Text = string.Format( "{0:" + this.Mask + "}", this.Value );
            }
        }

    }
}
