using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadLab3
{
    class FoodItem
    {
        private String name;
        private double weight;
        private double volume;

        /// <summary>
        /// Constructor that takes in three parameters such as a string and two double variables
        /// The instance variables will be delerced to the parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="volume"></param>
        public FoodItem(String name, double weight, double volume)
        {
            this.name = name;
            this.weight = weight;
            this.volume = volume;
        }

        /// <summary>
        /// A get-method that returns a string called name
        /// </summary>
        /// <returns></returns>
        public String getName()
        {
            return name;
        }

        /// <summary>
        /// A get-method that returns a double called weight
        /// </summary>
        /// <returns></returns>
        public double GetWeight()
        {
            return weight;
        }

        /// <summary>
        /// A get-method that returns a double called volume
        /// </summary>
        /// <returns></returns>
        public double GetVolume()
        {
            return volume;
        }
    }
}
