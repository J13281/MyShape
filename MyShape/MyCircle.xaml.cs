using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyShape
{
    public partial class MyCircle : UserControl, INotifyPropertyChanged
    {
        #region --DependencyProperty Define--
        public double Diameter
        {
            get { return (double)GetValue(DiameterProperty); }
            set { SetValue(DiameterProperty, value); }
        }

        public static readonly DependencyProperty DiameterProperty = DependencyProperty.Register(
            name: "Diameter",
            propertyType: typeof(double),
            ownerType: typeof(MyCircle),
            typeMetadata: new FrameworkPropertyMetadata(
                propertyChangedCallback: DiameterPropertyChangedCallback,
                coerceValueCallback: DiameterPropertyCoerceValueCallback));

        static void DiameterPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyCircle).DiameterPropertyChanged(e);
        }

        static object DiameterPropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyCircle).DiameterPropertyCoerceValue((double)baseValue);
        }

        void DiameterPropertyChanged(DependencyPropertyChangedEventArgs e) { }

        double DiameterPropertyCoerceValue(double baseValue) { return baseValue; }

        public double X
        {
            get { return (double)GetValue(XProperty); }
            set { SetValue(XProperty, value); }
        }

        public static readonly DependencyProperty XProperty = DependencyProperty.Register(
            name: "X",
            propertyType: typeof(double),
            ownerType: typeof(MyCircle),
            typeMetadata: new FrameworkPropertyMetadata(
                propertyChangedCallback: XPropertyChangedCallback,
                coerceValueCallback: XPropertyCoerceValueCallback));

        static void XPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyCircle).XPropertyChanged(e);
        }

        static object XPropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyCircle).XPropertyCoerceValue((double)baseValue);
        }

        void XPropertyChanged(DependencyPropertyChangedEventArgs e) { }

        double XPropertyCoerceValue(double baseValue) { return baseValue; }

        public double Y
        {
            get { return (double)GetValue(YProperty); }
            set { SetValue(YProperty, value); }
        }

        public static readonly DependencyProperty YProperty = DependencyProperty.Register(
            name: "Y",
            propertyType: typeof(double),
            ownerType: typeof(MyCircle),
            typeMetadata: new FrameworkPropertyMetadata(
                propertyChangedCallback: YPropertyChangedCallback,
                coerceValueCallback: YPropertyCoerceValueCallback));

        static void YPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyCircle).YPropertyChanged(e);
        }

        static object YPropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyCircle).YPropertyCoerceValue((double)baseValue);
        }

        void YPropertyChanged(DependencyPropertyChangedEventArgs e) { }

        double YPropertyCoerceValue(double baseValue) { return baseValue; }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            name: "Text",
            propertyType: typeof(string),
            ownerType: typeof(MyCircle),
            typeMetadata: new FrameworkPropertyMetadata(
                propertyChangedCallback: TextPropertyChangedCallback,
                coerceValueCallback: TextPropertyCoerceValueCallback));

        static void TextPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyCircle).TextPropertyChanged(e);
        }

        static object TextPropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyCircle).TextPropertyCoerceValue((string)baseValue);
        }

        void TextPropertyChanged(DependencyPropertyChangedEventArgs e) { }

        string TextPropertyCoerceValue(string baseValue) { return baseValue; }

        public Brush Fill
        {
            get { return (Brush)GetValue(FillProperty); }
            set { SetValue(FillProperty, value); }
        }

        public static readonly DependencyProperty FillProperty = DependencyProperty.Register(
            name: "Fill",
            propertyType: typeof(Brush),
            ownerType: typeof(MyCircle),
            typeMetadata: new FrameworkPropertyMetadata(
                defaultValue: Brushes.Black,
                propertyChangedCallback: FillPropertyChangedCallback,
                coerceValueCallback: FillPropertyCoerceValueCallback));

        static void FillPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyCircle).FillPropertyChanged(e);
        }

        static object FillPropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyCircle).FillPropertyCoerceValue((Brush)baseValue);
        }

        void FillPropertyChanged(DependencyPropertyChangedEventArgs e) { }

        Brush FillPropertyCoerceValue(Brush baseValue) { return baseValue; }
        #endregion

        #region --NotifyProperty Define--
        public event PropertyChangedEventHandler PropertyChanged;
        void SetProperty<T>(ref T storage, T value, [CallerMemberName] string name = null)
        {
            storage = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        double px;
        public double Px
        {
            get { return px; }
            set { SetProperty(ref px, value); }
        }

        double py;
        public double Py
        {
            get { return py; }
            set { SetProperty(ref py, value); }
        }

        double qx;
        public double Qx
        {
            get { return qx; }
            set { SetProperty(ref qx, value); }
        }

        double qy;
        public double Qy
        {
            get { return qy; }
            set { SetProperty(ref qy, value); }
        }
        #endregion

        public MyCircle()
        {
            InitializeComponent();
            LayoutUpdated += MyCircle_LayoutUpdated;
        }

        void MyCircle_LayoutUpdated(object sender, EventArgs e)
        {
            Px = X - Diameter / 2;
            Py = Y - Diameter / 2;
            Qx = X - textblock.ActualWidth / 2;
            Qy = Y - (Diameter + 2 * textblock.ActualHeight) / 2;
        }
    }
}