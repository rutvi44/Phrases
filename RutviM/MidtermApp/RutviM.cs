
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace MidtermApp
{
    public partial class RutviM : Form
    {
        //List to store patients scheduled for appointments
        private List<patientInformation> scheduledpatients;

        //Declare variable for maximum capacity to scheduled
        private const int MaxCapacitytoSchedule = 5;
        public RutviM()
        {
            InitializeComponent();
            scheduledpatients = new List<patientInformation>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //button Chceck availibity for 1st.
        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            //declare variable for textbox zipcode
            string checkZipcode = txtZipCode.Text;

            //Regex expression stored in variable for zipcode
            Regex zipcode = new Regex(@"^\d{5}(?:-\d{4})?$");

            //Chceck if string is null or empty and print the error  message in messagbox
            if (string.IsNullOrEmpty(checkZipcode))
            {
                MessageBox.Show("You must enter zip code. It should not be empty");
            }

            //Chceck if string match with regex expression and if not then print the error message in messagbox
            else if (!zipcode.IsMatch(checkZipcode))
            {
                MessageBox.Show("You must eneter valid US zip code (e.g. 94043 or 98052-6399)");
            }
            //Check if string is match with regex expression then print this message in messageBox
            else
            {
                MessageBox.Show($"{checkZipcode} is the valid US zip code.");
            }

        }

        //Button for remove Vowels for 2nd.
        private void btnRemoveVowels_Click(object sender, EventArgs e)
        {
            //declare variable for textbox of input text
            string inputText = txtInputText.Text;

            //Update string 
            string outputText = RemoveVowels(inputText);

            //to print the output in label
            lblOutput.Text = outputText;
        }

        //create a method to remove vowels
        private string RemoveVowels(string input)
        {
            //Declare vowels in variable
            string vowels = "AEIOUaeiou";

            //store the result in finalOutput variable
            StringBuilder finalOutput = new StringBuilder();

            //Chcek if any vowels is in string and print the output
            foreach (char c in input)
            {
                if (!vowels.Contains(c))
                {
                    finalOutput.Append(c);
                }
            }
            //return as a string
            return finalOutput.ToString();
        }

        //button to add schedule for patients for 4th
        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {
            //declare variable and store value which user input for patient's full name, medical record and age
            string fullName = txtPatientName.Text;
            string medicalrecord = txtMedicalRecord.Text;
            string pateintsAge = txtPatientAge.Text;

            //To validate patients information
            string error = "";
            bool patientsInformation = true;

            //check if string is null or wmpty for full name field and print the error message
            if (string.IsNullOrEmpty(fullName))
            {
                patientsInformation = false;
                error += "Enter patients first name and last name \n";
            }

            //Check if user enetered full name or not and if not then it will print the message
            else if (!IsFullName(fullName))
            {
                patientsInformation = false;
                error += "Please enter the pateit's First and last name \n";
            }

            // regex expression for medicalRecord 
            Regex medicalRecordValidation = new Regex(@"^[A-Z]{2}\s?-?\s?\d{5}$");

            //Check if medical record information enter properly or not and print the output
            if (string.IsNullOrEmpty(medicalrecord) || !medicalRecordValidation.IsMatch(medicalrecord))
            {
                patientsInformation = false;
                error += "Please enter a valid medical record (FK-31215 or FK 31215 or FK31215_.\n";
            }

            //check if valid age enter and if not then print an error message
            int age;
            if (!int.TryParse(pateintsAge, out age) || age < 0 || age > 120)
            {
                patientsInformation = false;
                error += "Please enter valid age between 1 to 110.\n";
            }


            //To add patient for schedule if valid information added and update the message accordingly
            if (patientsInformation)
            {
                if (scheduledpatients.Count >= MaxCapacitytoSchedule)
                {
                    error += "There is no place remaining to book scheduled appointment.\n";
                }
                else
                {
                    patientInformation newPatient = new patientInformation(fullName, medicalrecord, age);
                    scheduledpatients.Add(newPatient);
                    lblError.Text = "Patient added to the schedule.";
                }
            }
            //To print error messages
            if (!string.IsNullOrEmpty(error))
            {
                lblError.Text = error;
            }
        }

        //Validation for Full name
        private bool IsFullName(string fullName)
        {
            string[] name = fullName.Split(' ');
            return name.Length >= 2 && !string.IsNullOrWhiteSpace(name[0]) && !string.IsNullOrWhiteSpace(name[1]);
        }

        //patient information class
        public class patientInformation
        {
            public string FullName { get; set; }
            public string medicalRecord1 { get; set; }
            public int patientAge { get; set; }

            public string FirstName { get; private set; }
            public string LastName { get; private set; }


            public patientInformation(string fullName, string medicalRecord, int age)
            {
                FullName = fullName;
                medicalRecord1 = medicalRecord;
                patientAge = age;

                // split first and last name of patient
                string[] name = fullName.Split(' ');
                if (name.Length >= 2)
                {
                    FirstName = name[0];
                    LastName = name[1];
                }
                else
                {
                    FirstName = "";
                    LastName = "";
                }
            }

        }

        private void btnShowPatients_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();

            foreach (patientInformation patient in scheduledpatients)
            {
                string outPut = $"{patient.LastName.ToUpper()}, {patient.FirstName.ToUpper()} " +
                    $"({patient.medicalRecord1.ToUpper()}) Age: {patient.patientAge}";

                richTextBox.AppendText(outPut + Environment.NewLine);
            }
        }


        private void listBoxMatchingPhrases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //To show phrases in listBox 3rd.
        //Identify which of the following strings/phrases are a match for the regular expression:
        //\s[A - Z]\w* (\s|$)
        //A.I got an A?
        //B.My dog's a pug named Tazz, short for Tasmanian devil.
        //C.To be, or not to be, that is the question.
        //D.Mary, Mary, quite contrary... how does your garden grow?
        //E. That's not an eh, dear, that's an A
        //F. you need an M10 wrench
        //G. Is that like a 10MM wrench?

        private void RutviM_Load(object sender, EventArgs e)
        {
            listBoxMatchingPhrases.Items.Add("B");
            listBoxMatchingPhrases.Items.Add("E");
            listBoxMatchingPhrases.Items.Add("F");
        }
    }
}

