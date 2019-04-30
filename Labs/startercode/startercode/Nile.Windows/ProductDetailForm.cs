/*
 * ITSE 1430
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class ProductDetailForm : Form
    {
        #region Construction

        public ProductDetailForm () //: base()
        {
            InitializeComponent();            
        }
        
        public ProductDetailForm ( string title ) : this()
        {
            Text = title;
        }

        public ProductDetailForm( string title, Product product ) : this(title)
        {
            Product = product;
        }
        #endregion
        
        /// <summary>Gets or sets the product being shown.</summary>
        public Product Product { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            if (Product != null)
            {
                _txtName.Text = Product.Name;
                _txtDescription.Text = Product.Description;
                _txtPrice.Text = Product.Price.ToString();
                _chkDiscontinued.Checked = Product.IsDiscontinued;
            };

            ValidateChildren();
        }

        #region Event Handlers

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
            {
                return;
            };

            var product = new Product()
            {
                Id = Product?.Id ?? 0,
                Name = _txtName.Text,
                Description = _txtDescription.Text,
                Price = GetPrice(_txtPrice),
                IsDiscontinued = _chkDiscontinued.Checked,
            };

            Validator.ValidateObject(product, new ValidationContext(product));

            Product = product;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnValidatingName ( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;
            if (String.IsNullOrEmpty(tb.Text))
                _errors.SetError(tb, "Name is required");
            else
                _errors.SetError(tb, "");
        }

        private void OnValidatingPrice ( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (GetPrice(tb) < 0)
            {
                e.Cancel = true;
                _errors.SetError(_txtPrice, "Price must be >= 0.");
            } else
                _errors.SetError(_txtPrice, "");
        }
        #endregion

        #region Private Members

        private decimal GetPrice ( TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var price))
                return price;

            //Validate price            
            return -1;
        }                      
        #endregion
    }
}
