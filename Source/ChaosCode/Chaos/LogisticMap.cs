using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chaos
{
    class LogisticMap
    {
        private double mMu;

        /************************************************
        * Default Constructor for the LogisticMap class *
        ************************************************/
        public LogisticMap()
        {
            mMu = 1;
        }

        /****************************************
        * Constructor for the LogisticMap class *
        ****************************************/
        public LogisticMap(double mu)
        {
            mMu = mu;
        }

        /**********************************************************************************
        * Map() Method                                                                    *
        * Inputs:                                                                         *
        *     double x                                                                    *
        * Outputs                                                                         *
        *     none                                                                        *
        * Returns:                                                                        *
        *     double                                                                      *
        * Description:                                                                    *
        *     Returns the result of f(x).                                                 *
        **********************************************************************************/
        public double Map(double x)
        {
            double output = 4 * mMu * x * (1 - x);
            return output;
        }

        /***************************************
        * Properties of the LogisticMap class  *
        ***************************************/

        public double Mu
        {
            get { return mMu; }
            set { mMu = value; }
        }
    }
}
