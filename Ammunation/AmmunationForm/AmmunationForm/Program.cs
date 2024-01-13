using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmmunationForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(FormProvider.StartPageForm);
        }


        public class FormProvider
        {
            private static startPageForm _startPageForm;
            public static startPageForm StartPageForm
            {
                get
                {
                    if (_startPageForm == null)
                    {
                        _startPageForm = new startPageForm();
                    }
                    return _startPageForm;
                }
            }

            private static productForm _productForm;

            public static productForm ProductForm
            {
                get
                {
                    if (_productForm == null)
                    {
                        _productForm = new productForm();
                    }
                    return _productForm;
                }
            }

            private static shoppingCartForm _shoppingCart;

            public static shoppingCartForm ShoppingCart
            {
                get
                {
                    if (_shoppingCart == null)
                    {
                        _shoppingCart = new shoppingCartForm();
                    }
                    return _shoppingCart;
                }
            }

            private static createOrderForm _createOrderForm;

            public static createOrderForm CreateOrderForm
            {
                get
                {
                    if (_createOrderForm == null)
                    {
                        _createOrderForm = new createOrderForm();
                    }
                    return _createOrderForm;
                }
            }

            private static ordersForm _ordersForm;

            public static ordersForm OrdersForm
            {
                get
                {
                    if (_ordersForm == null)
                    {
                        _ordersForm = new ordersForm();
                    }
                    return _ordersForm;
                }
            }
        }
    }
}