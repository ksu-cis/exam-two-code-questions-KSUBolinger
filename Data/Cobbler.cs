using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit { get; set; }

        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        private bool cream = true;
        public bool WithIceCream
        {
            get { return cream; }
            set
            {
                cream = value;
                NotifyPropertyChanged("WithIceCream");
            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
