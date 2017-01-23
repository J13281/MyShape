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
    public partial class MyLine : UserControl, INotifyPropertyChanged
    {
        #region --DependencyProperty Define--
        public double X1
        {
            get { return (double)GetValue(X1Property); }
            set { SetValue(X1Property, value); }
        }

        public static readonly DependencyProperty X1Property = DependencyProperty.Register(
            name: "X1",
            propertyType: typeof(double),
            ownerType: typeof(MyLine),
            typeMetadata: new FrameworkPropertyMetadata(
                propertyChangedCallback: X1PropertyChangedCallback,
                coerceValueCallback: X1PropertyCoerceValueCallback));

        static void X1PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyLine).X1PropertyChanged(e);
        }

        static object X1PropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyLine).X1PropertyCoerceValue((double)baseValue);
        }

        void X1PropertyChanged(DependencyPropertyChangedEventArgs e) { }

        double X1PropertyCoerceValue(double baseValue) { return baseValue; }

        public double Y1
        {
            get { return (double)GetValue(Y1Property); }
            set { SetValue(Y1Property, value); }
        }

        public static readonly DependencyProperty Y1Property = DependencyProperty.Register(
            name: "Y1",
            propertyType: typeof(double),
            ownerType: typeof(MyLine),
            typeMetadata: new FrameworkPropertyMetadata(
                propertyChangedCallback: Y1PropertyChangedCallback,
                coerceValueCallback: Y1PropertyCoerceValueCallback));

        static void Y1PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyLine).Y1PropertyChanged(e);
        }

        static object Y1PropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyLine).Y1PropertyCoerceValue((double)baseValue);
        }

        void Y1PropertyChanged(DependencyPropertyChangedEventArgs e) { }

        double Y1PropertyCoerceValue(double baseValue) { return baseValue; }

        public double X2
        {
            get { return (double)GetValue(X2Property); }
            set { SetValue(X2Property, value); }
        }

        public static readonly DependencyProperty X2Property = DependencyProperty.Register(
            name: "X2",
            propertyType: typeof(double),
            ownerType: typeof(MyLine),
            typeMetadata: new FrameworkPropertyMetadata(
                propertyChangedCallback: X2PropertyChangedCallback,
                coerceValueCallback: X2PropertyCoerceValueCallback));

        static void X2PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyLine).X2PropertyChanged(e);
        }

        static object X2PropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyLine).X2PropertyCoerceValue((double)baseValue);
        }

        void X2PropertyChanged(DependencyPropertyChangedEventArgs e) { }

        double X2PropertyCoerceValue(double baseValue) { return baseValue; }

        public double Y2
        {
            get { return (double)GetValue(Y2Property); }
            set { SetValue(Y2Property, value); }
        }

        public static readonly DependencyProperty Y2Property = DependencyProperty.Register(
            name: "Y2",
            propertyType: typeof(double),
            ownerType: typeof(MyLine),
            typeMetadata: new FrameworkPropertyMetadata(
                propertyChangedCallback: Y2PropertyChangedCallback,
                coerceValueCallback: Y2PropertyCoerceValueCallback));

        static void Y2PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyLine).Y2PropertyChanged(e);
        }

        static object Y2PropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyLine).Y2PropertyCoerceValue((double)baseValue);
        }

        void Y2PropertyChanged(DependencyPropertyChangedEventArgs e) { }

        double Y2PropertyCoerceValue(double baseValue) { return baseValue; }

        public Brush Stroke
        {
            get { return (Brush)GetValue(StrokeProperty); }
            set { SetValue(StrokeProperty, value); }
        }

        public static readonly DependencyProperty StrokeProperty = DependencyProperty.Register(
            name: "Stroke",
            propertyType: typeof(Brush),
            ownerType: typeof(MyLine),
            typeMetadata: new FrameworkPropertyMetadata(
                defaultValue: Brushes.Black,
                propertyChangedCallback: StrokePropertyChangedCallback,
                coerceValueCallback: StrokePropertyCoerceValueCallback));

        static void StrokePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyLine).StrokePropertyChanged(e);
        }

        static object StrokePropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyLine).StrokePropertyCoerceValue((Brush)baseValue);
        }

        void StrokePropertyChanged(DependencyPropertyChangedEventArgs e) { }

        Brush StrokePropertyCoerceValue(Brush baseValue) { return baseValue; }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            name: "Text",
            propertyType: typeof(string),
            ownerType: typeof(MyLine),
            typeMetadata: new FrameworkPropertyMetadata(
                propertyChangedCallback: TextPropertyChangedCallback,
                coerceValueCallback: TextPropertyCoerceValueCallback));

        static void TextPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MyLine).TextPropertyChanged(e);
        }

        static object TextPropertyCoerceValueCallback(DependencyObject d, object baseValue)
        {
            return (d as MyLine).TextPropertyCoerceValue((string)baseValue);
        }

        void TextPropertyChanged(DependencyPropertyChangedEventArgs e) { }

        string TextPropertyCoerceValue(string baseValue) { return baseValue; }
        #endregion

        #region --NotifyProperty Define--
        public event PropertyChangedEventHandler PropertyChanged;
        void SetProperty<T>(ref T storage, T value, [CallerMemberName]string name = null)
        {
            storage = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        double left;
        public double Left
        {
            get { return left; }
            set { SetProperty(ref left, value); }
        }

        double top;
        public double Top
        {
            get { return top; }
            set { SetProperty(ref top, value); }
        }

        double angle;
        public double Angle
        {
            get { return angle; }
            set { SetProperty(ref angle, value); }
        }

        double x;
        public double X
        {
            get { return x; }
            set { SetProperty(ref x, value); }
        }

        double y;
        public double Y
        {
            get { return y; }
            set { SetProperty(ref y, value); }
        }
        #endregion

        public MyLine()
        {
            InitializeComponent();
            LayoutUpdated += MyLine_LayoutUpdated;
        }

        void MyLine_LayoutUpdated(object sender, EventArgs e)
        {
            var AB = (X2 - X1);
            AB = AB != 0 ? AB : 1;

            var BC = Y2 - Y1;
            var BAC = Math.Atan2(BC, AB);
            var AC = AB / Math.Cos(BAC);

            X = (AC - textblock.ActualWidth) / 2;
            Y = -textblock.ActualHeight;

            if (Math.Abs(BAC) > Math.PI / 2)
            {
                Left = X2;
                Top = Y2;
                Angle = (BAC * 180 / Math.PI) + 180;
            }
            else
            {
                Left = X1;
                Top = Y1;
                Angle = BAC * 180 / Math.PI;
            }
        }
    }
}