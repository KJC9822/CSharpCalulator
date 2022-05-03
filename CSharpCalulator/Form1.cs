using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//I would change the name but I don't want to fuck anything up, from now on CSharpCalculator is read as Kyle's Sub Shop//
namespace CSharpCalulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal subtotal;
        decimal total;
        decimal bread;
        decimal meat;
        decimal veggie;
        decimal condiments;
        decimal cheese;
        decimal tax;
   


        private void Form1_Load(object sender, EventArgs e)
        {
            WhiteRB.Checked = false;
            WheatRB.Checked = false;
            ItalianRB.Checked = false;
            HoagieRB.Checked = false;
            SteakRB.Checked = false;
            ChickenRB.Checked = false;
            TureyRB.Checked = false;
            RoastBeefRB.Checked = false;
            DoubleMeatCB.Checked = false;
            checkBox2.Checked = false;
            YAmericanRB.Checked = false;
            YAmericanRB.Checked = false;
            SwissRB.Checked = false;
            ProvoloneRB.Checked = false;
            PepperjackRB.Checked = false;
            CheddarRB.Checked = false;
            MuensterRB.Checked = false;
            MozzarellaRB.Checked = false;
            TomatoCB.Checked = false;
            LettuceCB.Checked = false;
            OnionCB.Checked = false;
            BellCB.Checked = false;
            JalapenoCB.Checked = false;
            PickleCB.Checked = false;
            OliveCB.Checked = false;
            AvocadoCB.Checked = false;
            GuacamoleCB.Checked = false;
            SpinachCB.Checked = false;
            SpicyMustardCB.Checked = false;
            ItalianDressingCB.Checked = false;
            RanchCB.Checked = false;
            MayoCB.Checked = false;
        }


        private void WheatRB_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void WhiteRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void HoagieRB_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ItalianRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void SteakRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ChickenRB_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void TureyRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void DoubleMeatCB_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void YAmericanRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ProvoloneRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MozzarellaRB_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void LettuceCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void BellCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void JalapenoCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void PickleCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void OliveCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void AvocadoCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void SpinachCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void SpicyMustardCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ItalianDressingCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RanchCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MayoCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void Calc_Click(object sender, EventArgs e)
        {
            if (WhiteRB.Checked == true)
            { bread = Decimal.Add(bread, 2); }
            else if (WheatRB.Checked == true)
            { bread += Decimal.Add(bread, 2); }
            else if (HoagieRB.Checked == true)
            { bread += Decimal.Add(bread, 2); }
            else if (ItalianRB.Checked == true)
            { bread += Decimal.Add( bread , 2); }

            if (SteakRB.Checked == true)
            { meat += Decimal.Add(meat , 3.50M); }
            else if (ChickenRB.Checked == true)
            { meat +=Decimal.Add( meat ,2.25M); }
            else if (TureyRB.Checked == true)
            { meat += Decimal.Add(meat , 2.50M); }
            else if (RoastBeefRB.Checked == true)
            { meat += Decimal.Add(meat , 3); }
            if (DoubleMeatCB.Checked == true)
            { meat += Decimal.Multiply(meat ,2); }

            if(YAmericanRB.Checked == true)
            { cheese += Decimal.Add(cheese, .5M);}
            else if (WAmericanRB.Checked == true)
            { cheese += Decimal.Add(cheese, .5M);}
            else if (SwissRB.Checked == true)
            { cheese += Decimal.Add(cheese, .5M);}
            else if (ProvoloneRB.Checked == true)
            { cheese += Decimal.Add(cheese, .5M);}
            else if (PepperjackRB.Checked == true)
            { cheese += Decimal.Add(cheese, .5M);}
            else if (CheddarRB.Checked == true)
            { cheese += Decimal.Add(cheese, .5M);}
            else if (MuensterRB.Checked == true)
            { cheese += Decimal.Add(cheese, .5M);}
            else if (MozzarellaRB.Checked == true)
            { cheese += Decimal.Add(cheese, .5M);}
            /*Double Cheese*/
            if (checkBox2.Checked == true)
            { cheese += Decimal.Multiply(cheese, 2); }
            
            if(TomatoCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}
            else if (LettuceCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}
            else if (OnionCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}
            else if (BellCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}
            else if (JalapenoCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}
            else if (PickleCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}
            else if (OliveCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}
            else if (AvocadoCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}
            else if (GuacamoleCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}
            else if (SpinachCB.Checked == true)
            { veggie += Decimal.Add(veggie,.25M);}

            if (SpicyMustardCB.Checked == true)
            { condiments += Decimal.Add(condiments,.25M); }
            if (ItalianDressingCB.Checked == true)
            { condiments += Decimal.Add(condiments,.25M); }
            if (RanchCB.Checked == true)
            { condiments += Decimal.Add(condiments,.25M); }
            if (MayoCB.Checked == true)
            { condiments += Decimal.Add(condiments,.25M); }

            /*PA Sales Tax */
            decimal taxrate = 0.06M;
            subtotal = bread + meat + cheese + veggie + condiments;
            tax = subtotal * taxrate;
            total = subtotal + tax;
            textBox1.Text = Convert.ToString(Math.Round(subtotal, 2));
            textBox3.Text = Convert.ToString(Math.Round(tax, 2));
            textBox2.Text = Convert.ToString(Math.Round(total, 2));


            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bread = 0;
            meat = 0;
            cheese = 0;
            veggie = 0;
            condiments = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
            textBox1.Text = Convert.ToString(null);
            textBox2.Text = Convert.ToString(null);
            textBox3.Text = Convert.ToString(null);
            WhiteRB.Checked = false;
            WheatRB.Checked = false;
            ItalianRB.Checked = false;
            HoagieRB.Checked = false;
            SteakRB.Checked = false;
            ChickenRB.Checked = false;
            TureyRB.Checked = false;
            RoastBeefRB.Checked = false;
            DoubleMeatCB.Checked = false;
            checkBox2.Checked = false;
            YAmericanRB.Checked = false;
            YAmericanRB.Checked = false;
            SwissRB.Checked = false;
            ProvoloneRB.Checked = false;
            PepperjackRB.Checked = false;
            CheddarRB.Checked = false;
            MuensterRB.Checked = false;
            MozzarellaRB.Checked = false;
            TomatoCB.Checked = false;
            LettuceCB.Checked = false;
            OnionCB.Checked = false;
            BellCB.Checked = false;
            JalapenoCB.Checked = false;
            PickleCB.Checked = false;
            OliveCB.Checked = false;
            AvocadoCB.Checked = false;
            GuacamoleCB.Checked = false;
            SpinachCB.Checked = false;
            SpicyMustardCB.Checked = false;
            ItalianDressingCB.Checked = false;
            RanchCB.Checked = false;
            MayoCB.Checked = false;
        }


    }
}
