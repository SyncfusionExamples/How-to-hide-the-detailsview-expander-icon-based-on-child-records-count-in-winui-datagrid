using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DetailsView_NestedLevel
{
    public class OrderInfo : INotifyPropertyChanged
    {
        #region private members

        private int orderId;
        private int _customerId;
        private double _unitPrice;
        private int _quantiy;
        private int decimalDigits;
        public int DecimalDigits
        {
            get { return decimalDigits; }
            set { decimalDigits = value; RaisePropertyChanged("DecimalDigits"); }
        }

        #endregion

        #region public properties

        public int OrderID
        {
            get
            {
                return orderId;
            }
            set
            {
                orderId = value;
               // RaisePropertyChanged("OrderID");
            }
        }

        public int CustomerID
        {
            get
            {
                return _customerId;
            }
            set
            {
                _customerId = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        public double UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
                RaisePropertyChanged("UnitPrice");
            }
        }
        [Range(105, 117, ErrorMessage = "Quantity can hold value between 105 and 117")]

        public int Quantity
        {
            get
            {
                return _quantiy;
            }
            set
            {
                _quantiy = value;
                RaisePropertyChanged("Quantity");
            }
        }

        private ObservableCollection<ProductInfo> productdetails;

        public ObservableCollection<ProductInfo> ProductDetails
        {
            get
            {
                return productdetails;
            }
            set
            {
                productdetails = value;
                RaisePropertyChanged("ProductDetails");
            }
        }

        #endregion

        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        //public string Error
        //{
        //    get { return null; }
        //}

        //public string this[string columnName]
        //{
        //    get
        //    {
        //        if (columnName.Equals("UnitPrice"))
        //        {
        //            if (this.UnitPrice > 109)
        //                return null;
        //            else
        //                return "UnitPrice sholud less than 109";
        //        }
        //        return null;
        //    }
        //}
    }
}
