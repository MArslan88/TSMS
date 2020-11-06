using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TSMS
{   
    public partial class Form1 : Form
    {      
        #region"Variables Decleration Section"
        // for 1st Signal 
        public static Boolean state1;
        public static Boolean state2;
        public static Boolean state3;
        public static Boolean state4;

        // for 2nd Signal 
        public static Boolean state5;
        public static Boolean state6;
        public static Boolean state7;
        public static Boolean state8;

        // for 3rd Signal
        public static Boolean state9;
        public static Boolean state10;
        public static Boolean state11;
        public static Boolean state12;
        // for 4th Signal
        public static Boolean state13;
        public static Boolean state14;
        public static Boolean state15;
        public static Boolean state16;

        
        public int Den1, Den2, Den3, Den4 = 0;
        public int Checker = 0;

        #endregion

        public Form1()
        {
            InitializeComponent();            
        }
        
        #region"Default View of Application form"        
        private void Form1_Load(object sender, EventArgs e)
        {
            // As a default hiding all the vehicle untile the check box is checked
            car1.Hide();
            bike1.Hide();
            bus1.Hide();
            truck1.Hide();
            amb1.Hide();

            car2.Hide();
            bike2.Hide();
            bus2.Hide();
            truck2.Hide();
            amb2.Hide();

            car3.Hide();
            bike3.Hide();
            bus3.Hide();
            truck3.Hide();
            amb3.Hide();

            car4.Hide();
            bike4.Hide();
            bus4.Hide();
            truck4.Hide();
            amb4.Hide();

            state1 = true;
            state2 = false;
            state3 = false;
            state4 = false;

            state5 = true;
            state6 = false;
            state7 = false;
            state8 = false;
            
            state9 = true;
            state10 = false;
            state11 = false;
            state12 = false;

            state13 = true;
            state14 = false;
            state15 = false;
            state16 = false;

            if (state1 && state5 && state9 && state13 == true)
            {
                //1st signal Default
                Red1.BackColor = Color.Red;
                Orange1.BackColor = Color.White;
                Green1.BackColor = Color.White;
                

                //2nd Signal Default 
                Red2.BackColor = Color.Red;
                Orange2.BackColor = Color.White;
                Green2.BackColor = Color.White;

                //3rd Signal Default 
                Red3.BackColor = Color.Red;
                Orange3.BackColor = Color.White;
                Green3.BackColor = Color.White;

                //4th Signal Default 
                Red4.BackColor = Color.Red;
                Orange4.BackColor = Color.White;
                Green4.BackColor = Color.White;
            }

        }
        #endregion

        #region"Starting Point of Application"
                
        private void Start_Click(object sender, EventArgs e)
        {            
            // if there is no traffic
            if (Den1 == Den2 && Den2 == Den3 && Den3 == Den4 && Den4 == 0)
            {                
                if (MessageBox.Show("Do you want to close the application?", "TSMS",
                MessageBoxButtons.YesNo , MessageBoxIcon.Question ) == DialogResult.Yes )
                     
                {
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }

            }
                // if there is Traffic on a ROAD
            else if (Den1 >= Den2 && Den1 >= Den3 && Den1 >= Den4)
            {
                Start_time1();
            }
            else if (Den2 >= Den3 && Den2 >= Den4)
            {
                Start_time2();
            }
            else if (Den3 >= Den4)
            {
                Start_time3();
            }
            else
            {
                Start_time4();
            }

        }
        #endregion

        #region"Timer setting"
        
        private void Start_time1()
        {
            Checker = 1;
            timer1.Start();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }
        
        private void Start_time2()
        {
            Checker = 2;
            timer1.Stop();
            timer2.Start();
            timer3.Stop();
            timer4.Stop();
        }
        
        private void Start_time3()
        {
            Checker = 3;
            timer1.Stop();
            timer2.Stop();
            timer3.Start();
            timer4.Stop();
        }
        
        private void Start_time4()
        {
            Checker = 4;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Start();
        }
        #endregion

        #region"Road Signal's Setting"

        
        // Methods for Signals
        public void _Orange()
        {
            if (Checker == 1)
            {
                Red1.BackColor = Color.White;
                Orange1.BackColor = Color.Orange;
                Green1.BackColor = Color.White;
            }
            else if (Checker == 2)
            {
                Red2.BackColor = Color.White;
                Orange2.BackColor = Color.Orange;
                Green2.BackColor = Color.White;
            }
            else if (Checker == 3)
            {
                Red3.BackColor = Color.White;
                Orange3.BackColor = Color.Orange;
                Green3.BackColor = Color.White;
            }
            else if (Checker == 4)
            {
                Red4.BackColor = Color.White;
                Orange4.BackColor = Color.Orange;
                Green4.BackColor = Color.White;
            }
        }        
        public void _Green()
        {
            if (Checker == 1)
            {
                Red1.BackColor = Color.White;
                Orange1.BackColor = Color.White;
                Green1.BackColor = Color.Green;
            }
            else if (Checker == 2)
            {
                Red2.BackColor = Color.White;
                Orange2.BackColor = Color.White;
                Green2.BackColor = Color.Green; 
            }
            else if (Checker == 3)
            {
                Red3.BackColor = Color.White;
                Orange3.BackColor = Color.White;
                Green3.BackColor = Color.Green;
            }
            else if (Checker == 4)
            {
                Red4.BackColor = Color.White;
                Orange4.BackColor = Color.White;
                Green4.BackColor = Color.Green;
            }
            
        }
        public void _Red()
        {
            if (Checker == 1)
            {
                Red1.BackColor = Color.Red;
                Orange1.BackColor = Color.White;
                Green1.BackColor = Color.White;
            }
            else if (Checker == 2)
            {
                Red2.BackColor = Color.Red;
                Orange2.BackColor = Color.White;
                Green2.BackColor = Color.White;
            }
            else if (Checker == 3)
            {
                Red3.BackColor = Color.Red;
                Orange3.BackColor = Color.White;
                Green3.BackColor = Color.White;
            }
            else if (Checker == 4)
            {
                Red4.BackColor = Color.Red;
                Orange4.BackColor = Color.White;
                Green4.BackColor = Color.White;
            }            
        }
        
        
        // Setting of Road # 1 Signals
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (state1 == true)
            {
                state1 = false;
                state2 = true;
                _Orange();
            }
            else if (state2 == true)
            {

                state2 = false;
                state3 = true;
                _Green();

                // Increasing a time of Green Signal for traffic flow
                timer1.Interval = 8500;
                timer5.Interval = 10;
                timer5.Start();
            }

            else if (state3 == true)
            {
                // Decreasing a time of Orange Signal
                timer1.Interval = 2000;
                timer5.Stop();
                {
                    // to hide the Vehicles after changing Green signal into Orange
                    cbcar1.Checked = false;
                    cbbike1.Checked = false;
                    cbbus1.Checked = false;
                    cbtruck1.Checked = false;
                    cbemrg1.Checked = false;

                    // Positioning the Vehicles to the Default position
                    car1.Location = new Point(73, 283);
                    bike1.Location = new Point(60, 335);
                    bus1.Location = new Point(189, 283);
                    truck1.Location = new Point(177, 335);
                    amb1.Location = new Point(-39, 329);
                }
                
                state3 = false;
                state4 = true;
                _Orange();
            }
            else if (state4 == true)
            {
                state4 = false;
                state1 = true;
                _Red();

                timer1.Stop();
                Start.Enabled = false;
                Start_Click(new object(), new EventArgs());
            }
        }
                
        // Setting of Road # 2 Signals        
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (state5 == true)
            {
                state5 = false;
                state6 = true;
                _Orange();
            }
            else if (state6 == true)
            {

                state6 = false;
                state7 = true;
                _Green();

                // Increasing a time of Green Signal for traffic flow
                timer2.Interval = 7000;
                timer6.Interval = 10;
                timer6.Start();
            }


            else if (state7 == true)
            {
                // Decreasing a time of Orange Signal
                timer2.Interval = 2000;
                timer6.Stop();
                {
                    // to hide the Vehicles after changing Green signal into Orange
                    cbcar2.Checked = false;
                    cbbike2.Checked = false;
                    cbbus2.Checked = false;
                    cbtruck2.Checked = false;
                    cbemerg2.Checked = false;

                    // Positioning the Vehicles to the Default position
                    car2.Location = new Point(453, 554);
                    bike2.Location = new Point(457, 632);
                    bus2.Location = new Point(391, 695);
                    truck2.Location = new Point(380, 579);
                    amb2.Location = new Point(450, 718);
                }
                
                state7 = false;
                state8 = true;
                _Orange();
            }

            else if (state8 == true)
            {
                state8 = false;
                state5 = true;
                _Red();

                timer2.Stop();
                Start.Enabled = false;
                Start_Click(new object(), new EventArgs());
            }
        }
                
        // Setting of Road # 3 Signals        
        private void timer3_Tick(object sender, EventArgs e)
        {   
            if (state9 == true)
            {
                state9 = false;
                state10 = true;
                _Orange();
            }
            else if (state10 == true)
            {

                state10 = false;
                state11 = true;
                _Green();

                // Increasing a time of Green Signal for traffic flow
                timer3.Interval = 8500;
                timer7.Interval = 10;
                timer7.Start();
            }


            else if (state11 == true)
            {
                // Decreasing a time of Orange Signal
                timer3.Interval = 2000;
                timer7.Stop();
                {
                    // to hide the Vehicles after changing Green signal into Orange
                    cbtruck3.Checked = false;
                    cbbus3.Checked = false;
                    cbbike3.Checked = false;
                    cbcar3.Checked = false;
                    cbemerg3.Checked = false;

                    // Positioning the Vehicles to the Default position
                    car3.Location = new Point(740, 395);
                    bike3.Location = new Point(750, 453);
                    bus3.Location = new Point(856, 392);
                    truck3.Location = new Point(862, 460);
                    amb3.Location = new Point(954, 392);
                }

                state11 = false;
                state12 = true;
                _Orange();
            }

            else if (state12 == true)
            {
                state12 = false;
                state9 = true;
                _Red();

                timer3.Stop();
                Start.Enabled = false;
                Start_Click(new object(), new EventArgs());
            }

        }
               
        // Setting of Road # 4 Signals       
        private void timer4_Tick(object sender, EventArgs e)
        {  
            if (state13 == true)
            {
                state13 = false;
                state14 = true;
                _Orange();
            }
            else if (state14 == true)
            {

                state14 = false;
                state15 = true;
                _Green();

                // Increasing a time of Green Signal for traffic flow
                timer4.Interval = 7000;
                timer8.Interval = 10;
                timer8.Start();
            }


            else if (state15 == true)
            {
                // Decreasing a time of Orange Signal
                timer4.Interval = 2000;
                timer8.Stop();
                {
                    //to hide the Vehicles after changing Green signal into Orange
                    cbtruck4.Checked = false;
                    cbbus4.Checked = false;
                    cbbike4.Checked = false;
                    cbcar4.Checked = false;
                    cbemerg4.Checked = false;

                    // Positioning the Vehicles to the Default position
                    car4.Location = new Point(526, 34);
                    bike4.Location = new Point(599, 12);
                    bus4.Location = new Point(529, 116);
                    truck4.Location = new Point(601, 98);
                    amb4.Location = new Point(526, -58);                    
                }               

                state15 = false;
                state16 = true;
                _Orange();
            }

            else if (state16 == true)
            {
                state16 = false;
                state13 = true;
                _Red();

                timer4.Stop();
                Start.Enabled = false;
                Start_Click(new object(), new EventArgs());
            }            
        }

        #endregion

        #region"Vehicles Movement setting"
        
        // Movement of Vehicles on Road # 1        
        
        private void timer5_Tick(object sender, EventArgs e)
        {            
            car1.Location = new Point(car1.Location.X+2 , car1.Location.Y);
            bike1.Location = new Point(bike1.Location.X + 2, bike1.Location.Y);
            bus1.Location = new Point(bus1.Location.X + 2, bus1.Location.Y);
            truck1.Location = new Point(truck1.Location.X + 2, truck1.Location.Y);
            amb1.Location = new Point(amb1.Location.X + 2, amb1.Location.Y);
        }

        // Movement of Vehicles on Road # 2
        
        private void timer6_Tick(object sender, EventArgs e)
        {         
            car2.Location = new Point(car2.Location.X , car2.Location.Y-2);
            bike2.Location = new Point(bike2.Location.X , bike2.Location.Y-2);
            bus2.Location = new Point(bus2.Location.X, bus2.Location.Y-2);
            truck2.Location = new Point(truck2.Location.X , truck2.Location.Y-2);
            amb2.Location = new Point(amb2.Location.X, amb2.Location.Y - 2);
        }

        // Movement of Vehicles on Road # 3
        
        private void timer7_Tick(object sender, EventArgs e)
        {            
            car3.Location = new Point(car3.Location.X - 2, car3.Location.Y);
            bike3.Location = new Point(bike3.Location.X - 2, bike3.Location.Y);
            bus3.Location = new Point(bus3.Location.X - 2, bus3.Location.Y);
            truck3.Location = new Point(truck3.Location.X - 2, truck3.Location.Y);
            amb3.Location = new Point(amb3.Location.X - 2, amb3.Location.Y);
        }

        // Movement of Vehicles on Road # 4
        
        private void timer8_Tick(object sender, EventArgs e)
        {
            car4.Location = new Point(car4.Location.X, car4.Location.Y + 2);
            bike4.Location = new Point(bike4.Location.X, bike4.Location.Y + 2);
            bus4.Location = new Point(bus4.Location.X, bus4.Location.Y + 2);
            truck4.Location = new Point(truck4.Location.X, truck4.Location.Y + 2);
            amb4.Location = new Point(amb4.Location.X, amb4.Location.Y + 2);
        }
        #endregion
        
        #region"Vehicles Selection"

        // Methods for road Dencity
        private void ForRoad1()
        {
            Vehicles Road1Vehicles = new Vehicles(Den1);
            Road1Vehicles.Dencity(Den1);
            Denc1.Text = Road1Vehicles.Traffic_Dencity;
        }
        private void ForRoad2() 
        {
            Vehicles Road2Vehicles = new Vehicles(Den2);
            Road2Vehicles.Dencity(Den2);
            Denc2.Text = Road2Vehicles.Traffic_Dencity;
        }
        private void ForRoad3()
        {
            Vehicles Road3Vehicles = new Vehicles(Den3);
            Road3Vehicles.Dencity(Den3);
            Denc3.Text = Road3Vehicles.Traffic_Dencity;
        }
        private void ForRoad4()
        {
            Vehicles Road4Vehicles = new Vehicles(Den4);
            Road4Vehicles.Dencity(Den4);
            Denc4.Text = Road4Vehicles.Traffic_Dencity;
        }
       
        // Methods for Emergency Exception
        private void Emergency_OnRoad_1()
        {
            Emergency Road1Vehicles = new Emergency(Den1);
            Road1Vehicles.InspectEmergency(Den1);
            Denc1.Text = Road1Vehicles.VehicleNo;
        }
        private void Emergency_OnRoad_2()
        {
            Emergency Road2Vehicles = new Emergency(Den2);
            Road2Vehicles.InspectEmergency(Den2);
            Denc2.Text = Road2Vehicles.VehicleNo;
        }
        private void Emergency_OnRoad_3()
        {
            Emergency Road3Vehicles = new Emergency(Den3);
            Road3Vehicles.InspectEmergency(Den3);
            Denc3.Text = Road3Vehicles.VehicleNo;
        }
        private void Emergency_OnRoad_4()
        {
            Emergency Road4Vehicles = new Emergency(Den4);
            Road4Vehicles.InspectEmergency(Den4);
            Denc4.Text = Road4Vehicles.VehicleNo;
        }

        // traffic selection for Road 1
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbcar1.Checked)
            {
                car1.Show();
                Den1++;
            }
            else
            {
                car1.Hide();
                Den1--;                
            }
            ForRoad1(); //Road 1 Dencity Method call
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbike1.Checked)
            {
                bike1.Show();
                Den1++;                
            }
            else
            {
                bike1.Hide();
                Den1--;                
            }
            ForRoad1(); //Road 1 Dencity Method call
            
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbus1.Checked)
            {
                bus1.Show();
                Den1++;
            }
            else
            {
                bus1.Hide();
                Den1--;
            }
            ForRoad1(); //Road 1 Dencity Method call
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtruck1.Checked)
            {
                truck1.Show();
                Den1++;
            }
            else
            {
                truck1.Hide();
                Den1--;
            }
            ForRoad1(); //Road 1 Dencity Method call
        }

        // traffic selection for Road 2
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcar2.Checked)
            {
                car2.Show();
                Den2++;
            }
            else
            {
                car2.Hide();
                Den2--;
            }
            ForRoad2(); //Road 2 Dencity Method call
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbike2.Checked)
            {
                bike2.Show();
                Den2++;
            }
            else
            {
                bike2.Hide();
                Den2--;
            }
            ForRoad2(); //Road 2 Dencity Method call
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbus2.Checked)
            {
                bus2.Show();
                Den2++;
            }
            else
            {
                bus2.Hide();
                Den2--;
            }
            ForRoad2(); //Road 2 Dencity Method call
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtruck2.Checked)
            {
                truck2.Show();
                Den2++;
            }
            else
            {
                truck2.Hide();
                Den2--;
            }
            ForRoad2(); //Road 2 Dencity Method call
        }

        // traffic selection for Road 3
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcar3.Checked)
            {
                car3.Show();
                Den3++;
            }
            else
            {
                car3.Hide();
                Den3--;
            }
            ForRoad3(); //Road 3 Dencity Method call
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbike3.Checked)
            {
                bike3.Show();
                Den3++;
            }
            else
            {
                bike3.Hide();
                Den3--;
            }
            ForRoad3(); //Road 3 Dencity Method call
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbus3.Checked)
            {
                bus3.Show();
                Den3++;
            }
            else
            {
                bus3.Hide();
                Den3--;
            }
            ForRoad3(); //Road 3 Dencity Method call
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtruck3.Checked)
            {
                truck3.Show();
                Den3++;
            }
            else
            {
                truck3.Hide();
                Den3--;
            }
            ForRoad3(); //Road 3 Dencity Method call
        }

        // traffic selection for Road 4
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcar4.Checked)
            {
                car4.Show();
                Den4++;
            }
            else
            {
                car4.Hide();
                Den4--;
            }
            ForRoad4(); //Road 4 Dencity Method call
        }
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbike4.Checked)
            {
                bike4.Show();
                Den4++;
            }
            else
            {
                bike4.Hide();
                Den4--;
            }
            ForRoad4(); //Road 4 Dencity Method call
        }
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbus4.Checked)
            {
                bus4.Show();
                Den4++;
            }
            else
            {
                bus4.Hide();
                Den4--;
            }
            ForRoad4(); //Road 4 Dencity Method call
        }
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtruck4.Checked)
            {
                truck4.Show();
                Den4++;
            }
            else
            {
                truck4.Hide();
                Den4--;
            }
            ForRoad4(); //Road 4 Dencity Method call
        }
        #endregion
        
        #region"Emergency Vehicles Selection"
        
        private void chcbxEmrg1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbemrg1.Checked)
            {
                amb1.Show();
                Den1=Den1+5;
            }
            else
            {
                amb1.Hide();
                Den1 = Den1 - 5;
            }
            Emergency_OnRoad_1(); //Road 1 Emergency Method call
        }
        private void chcbxEmrg2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbemerg2.Checked)
            {
                amb2.Show();
                Den2 = Den2 + 5;
            }
            else
            {
                amb2.Hide();
                Den2 = Den2 - 5;
            }
            Emergency_OnRoad_2(); //Road 2 Emergency Method call
        }
        private void chcbxEmrg3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbemerg3.Checked)
            {
                amb3.Show();
                Den3 = Den3 + 5;
            }
            else
            {
                amb3.Hide();
                Den3 = Den3 - 5;
            }
            Emergency_OnRoad_3(); //Road 3 Emergency Method call
        }
        private void chcbxEmrg4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbemerg4.Checked)
            {
                amb4.Show();
                Den4 = Den4 + 5;
            }
            else
            {
                amb4.Hide();
                Den4 = Den4 - 5;
            }
            Emergency_OnRoad_4(); //Road 4 Emergency Method call
        }
        #endregion

        #region"Vehicle Information"
        // Information of Road 1 Traffic
        private void car1_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vc1 = new Vehicles();
            label2.Text = Vc1.Categories("Corolla");
            label5.Text = Vc1.Vehicle_ID("MTV-9784");            
        }
        private void car1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text =label5.Text= "";
        }

        private void bus1_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vb1 = new Vehicles();
            label2.Text = Vb1.Categories("Mazda");
            label5.Text = Vb1.Vehicle_ID("LVT-9463");
        }
        private void bus1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void bike1_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vbk1 = new Vehicles();
            label2.Text = Vbk1.Categories("Honda-125");
            label5.Text = Vbk1.Vehicle_ID("KHV-8175");
        }
        private void bike1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void truck1_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vtr1 = new Vehicles();
            label2.Text = Vtr1.Categories("HINO");
            label5.Text = Vtr1.Vehicle_ID("HGV-7392");
        }
        private void truck1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void amb1_MouseHover(object sender, EventArgs e)
        {
            Emergency Vem1 = new Emergency();
            label2.Text = Vem1.Categories("Ambulance");
            label5.Text = Vem1.Vehicle_ID("UVN-1276");
        }
        private void amb1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }


        // Information of Road 2 Traffic
        private void car2_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vc1 = new Vehicles();
            label2.Text = Vc1.Categories("Corolla");
            label5.Text = Vc1.Vehicle_ID("MTV-6354");
        }
        private void car2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void bus2_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vb1 = new Vehicles();
            label2.Text = Vb1.Categories("Mazda");
            label5.Text = Vb1.Vehicle_ID("LVT-6823");
        }
        private void bus2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }
        
        private void bike2_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vbk1 = new Vehicles();
            label2.Text = Vbk1.Categories("Honda-125");
            label5.Text = Vbk1.Vehicle_ID("KHV-6057");
        }
        private void bike2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void truck2_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vtr1 = new Vehicles();
            label2.Text = Vtr1.Categories("HINO");
            label5.Text = Vtr1.Vehicle_ID("HGV-6943");
        }
        private void truck2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }               

        private void amb2_MouseHover(object sender, EventArgs e)
        {
            Emergency Vem1 = new Emergency();
            label2.Text = Vem1.Categories("Ambulance");
            label5.Text = Vem1.Vehicle_ID("UVN-5342");
        }
        private void amb2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }


        // Information of Road 3 Traffic
        private void car3_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vc1 = new Vehicles();
            label2.Text = Vc1.Categories("Corolla");
            label5.Text = Vc1.Vehicle_ID("MTV-9675");
        }
        private void car3_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void bus3_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vb1 = new Vehicles();
            label2.Text = Vb1.Categories("Mazda");
            label5.Text = Vb1.Vehicle_ID("LVT-7867");
        }
        private void bus3_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void bike3_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vbk1 = new Vehicles();
            label2.Text = Vbk1.Categories("Honda-125");
            label5.Text = Vbk1.Vehicle_ID("KHV-8462");
        }
        private void bike3_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void truck3_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vtr1 = new Vehicles();
            label2.Text = Vtr1.Categories("HINO");
            label5.Text = Vtr1.Vehicle_ID("HGV-9823");
        }
        private void truck3_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void amb3_MouseHover(object sender, EventArgs e)
        {
            Emergency Vem1 = new Emergency();
            label2.Text = Vem1.Categories("Ambulance");
            label5.Text = Vem1.Vehicle_ID("UVN-6655");
        }
        private void amb3_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }


        // Information of Road 4 Traffic
        private void car4_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vc1 = new Vehicles();
            label2.Text = Vc1.Categories("Corolla");
            label5.Text = Vc1.Vehicle_ID("MTV-6354");
        }
        private void car4_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void bus4_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vb1 = new Vehicles();
            label2.Text = Vb1.Categories("Mazda");
            label5.Text = Vb1.Vehicle_ID("LVT-9867");
        }
        private void bus4_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void bike4_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vbk1 = new Vehicles();
            label2.Text = Vbk1.Categories("Honda-125");
            label5.Text = Vbk1.Vehicle_ID("KJT-9867");
        }
        private void bike4_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void truck4_MouseHover(object sender, EventArgs e)
        {
            Vehicles Vtr1 = new Vehicles();
            label2.Text = Vtr1.Categories("HINO");
            label5.Text = Vtr1.Vehicle_ID("HGV-9908");
        }
        private void truck4_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        private void amb4_MouseHover(object sender, EventArgs e)
        {
            Emergency Vem1 = new Emergency();
            label2.Text = Vem1.Categories("Ambulance");
            label5.Text = Vem1.Vehicle_ID("UVN-8787");
        }
        private void amb4_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = label5.Text = "";
        }

        #endregion
    }
}