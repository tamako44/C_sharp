using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_obj
{
    class operatorButton : Button
    {
    }

    /// <summary>
    /// For ["+", "-", "X", "/"]
    /// </summary>
    class basicOpButton : operatorButton
    {

    }

    /// <summary>
    /// For ["%", " √ ", "x²", "¹/x", "±"]
    /// </summary>
    class spOpButton : operatorButton
    {

    }

    /// <summary>
    /// For ["="]
    /// </summary>
    class equalButton : operatorButton
    {

    }


}
