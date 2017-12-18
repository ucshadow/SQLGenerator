using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLStatementGenerator
{
    class Values
    {
        private String[] girlNames = {"Emily", "Madison", "Emma", "Hannah", "Olivia", "Abigail", "Isabella", "Ashley", "Samantha", "Elizabeth", "Alexis", "Sarah", "Alyssa", "Grace", "Sophia", "Taylor", "Brianna", "Lauren",
            "Ava", "Kayla", "Jessica", "Natalie", "Chloe", "Anna", "Victoria", "Hailey", "Mia", "Sydney", "Jasmine", "Morgan", "Julia", "Destiny", "Rachel", "Megan", "Kaitlyn", "Katherine", "Jennifer", "Savannah", "Ella",
            "Alexandra", "Haley", "Allison", "Maria", "Nicole", "Mackenzie", "Brooke", "Makayla", "Kaylee", "Lily", "Stephanie", "Andrea", "Faith", "Amanda", "Katelyn", "Kimberly", "Madeline", "Gabrielle", "Zoe", "Trinity",
            "Alexa", "Mary", "Jenna", "Lillian", "Paige", "Kylie", "Gabriella", "Rebecca", "Jordan", "Sara", "Addison", "Michelle", "Riley", "Vanessa", "Angelina", "Leah", "Caroline", "Sofia", "Audrey", "Maya", "Avery", "Evelyn",
            "Autumn", "Amber", "Ariana", "Jocelyn", "Claire", "Jada", "Danielle", "Bailey", "Isabel", "Arianna", "Sierra", "Mariah", "Aaliyah", "Melanie", "Erin", "Nevaeh", "Brooklyn", "Marissa", "Jacqueline" };

        private String[] boyNames = { "Jacob", "Michael", "Joshua", "Matthew", "Christopher", "Andrew", "Daniel", "Ethan", "Joseph", "William", "Anthony", "Nicholas", "David", "Alexander", "Ryan", "Tyler", "James", "John", "Jonathan",
            "Brandon", "Christian", "Dylan", "Zachary", "Noah", "Samuel", "Benjamin", "Nathan", "Logan", "Justin", "Jose", "Gabriel", "Austin", "Kevin", "Caleb", "Robert", "Elijah", "Thomas", "Jordan", "Cameron", "Hunter", "Jack", "Angel",
            "Isaiah", "Jackson", "Evan", "Luke", "Jason", "Isaac", "Mason", "Aaron", "Connor", "Gavin", "Kyle", "Jayden", "Aidan", "Juan", "Luis", "Charles", "Aiden", "Adam", "Brian", "Eric", "Lucas", "Sean", "Nathaniel", "Alex", "Adrian",
            "Carlos", "Bryan", "Ian", "Jesus", "Owen", "Julian", "Cole", "Landon", "Diego", "Steven", "Chase", "Timothy", "Jeremiah", "Sebastian", "Xavier", "Devin", "Cody", "Seth", "Hayden", "Blake", "Richard", "Carter", "Wyatt", "Dominic",
            "Antonio", "Jaden", "Miguel", "Brayden", "Patrick", "Alejandro", "Carson", "Jesse", "Tristan"};

        private String[] familyNames = { "Agard", "Ager", "Agner", "Alling", "Amundsen", "Andersen", "Andreassen", "Anker", "Antonsen", "Arntzen", "Asmus", "Asmussen", "Axelsen", "Bacher", "Backer", "Bagge", "Balle", "Balling", "Bang",
            "Bank", "Basse", "Bech", "Bekker", "Bendt", "Bergesen", "Berndsen", "Bernsen", "Berthelsen", "Beske", "Bidstrup", "Bihl", "Bille", "Biller", "Billing", "Bing", "Birk", "Birky", "Bissen", "Bjorn", "Bjornsen", "Black", "Bloch",
            "Blomberg", "Bo", "Bode", "Boe", "Bohr", "Boisen", "Bolding", "Bolt", "Bonne", "Borck", "Borge", "Borgen", "Borges", "Bork", "Borre", "Borresen", "Borum", "Borup", "Boss", "Bossen", "Bott", "Bove", "Boyer", "Bram", "Brander",
            "Branner", "Bredahl", "Bredenberg", "Breining", "Brix", "Bruun", "Buch", "Bus", "Busk", "Buske", "Buss", "Buus", "Carlsen", "Caspersen", "Christensen", "Christesen", "Christiansen", "Christoffersen", "Clemensen", "Colding",
            "Collin", "Corse", "Dall", "Damgaard", "Danielsen", "Dastrup", "Dethlefsen", "Detlefsen", "Didriksen", "Digman", "Drewes", "Drews", "Drost", "Due", "Duer", "Duus", "Ege", "Egeberg", "Eilert", "Eilertsen", "Eliasen", "Eliassen",
            "Erichsen", "Ericksen", "Espersen", "Faaborg", "Fano", "Farver", "Felsing", "Fey", "Finne", "Fiske", "Floor", "Fly", "Fogt", "Foss", "Frederiksen", "Frieberg", "Frier", "Frisk", "Froberg", "From", "Fugleberg", "Gad", "Gade",
            "Garbers", "Gilberg", "Gram", "Grand", "Greisen", "Gulbransen", "Gulliksen", "Gundersen", "Gunst", "Gustavsen", "Haagen", "Haagensen", "Hagemann", "Hansen", "Hanssen", "Hassing", "Hatke", "Hauge", "Hee", "Hegner", "Heinsen", "Helgesen",
            "Helt", "Hemmingsen", "Henrichsen", "Henriksen", "Hertz", "Hillner", "Hinrichsen", "Hjelm", "Hjort", "Hoeg", "Holme", "Holten", "Hom", "Hoppe", "Host", "Hoy", "Hoyer", "Ibsen", "Ingwersen", "Ipsen", "Iversen", "Jansen", "Jensen", "Jenssen",
            "Jepperson", "Jeppesen", "Jeppsen", "Jepsen", "Jespersen", "Jessen", "Johannesen", "Johannessen", "Johnsen", "Jorgensen", "Juel", "Juhl", "Jurs", "Justesen", "Juul", "Kaas", "Kahr", "Kai", "Karlsen"};

        private String[] departments = { "Purple Electronics", "Enigma Electronics", "Mount Solutions", "Crowares", "Padlockurity", "Omegacoustics", "Titaniumotors", "Joybooks", "Wizardwater", "Robinmaster",
            "Specter Corp", "Ridge Arts", "Sprite Motors", "Sawwares", "Marblightning", "Cubrews", "Gorillacoustics", "Crystalnite", "Signman", "Quadphone",
            "Fire Foods", "Fire Industries", "Signal Arts", "Angelico", "Globaviations", "Parableutions", "Orco", "Wonderex", "Houndfruit", "Gorillabridge",
            "Iceberg Security", "Wave Foods", "Mermaid Solutions", "Squidustries", "Betarts", "Parableutions", "Pinnaclelectrics", "Microgold", "Phoenixstones", "Wizardwell",
            "Enigma Productions", "Accent ", "Pinnacle Entertainment", "Herolutions", "Amazystems", "Elecoms", "Timberecords", "Luckyshow", "Acegold", "Joyshine",
            "Orange Industries", "Whiteout Sports", "Omega Coms", "Bridgelectrics", "Deserprises", "Silverecords", "Stormedia", "Yewshine", "Hummingnite", "Greenmedia"
        };

        private String[] cities = { "Copenhagen", "Copenhagen", "Frederiksberg", "Gentofte", "Gladsaxe", "Lyngby-Taarbæk", "Hvidovre", "GreveStrand", "Tårnby", "Ballerup", "Rødovre", "Brøndby", "Herlev", "Albertslund", "Glostrup", "Ishøj", "Rudersdal",
            "Vallensbæk", "Furesø", "Aarhus", "Odense", "Aalborg", "Esbjerg", "Randers", "Kolding", "Horsens", "Vejle", "Roskilde", "Herning", "Hørsholm", "Helsingør", "Silkeborg", "Næstved", "Fredericia", "Viborg", "Køge", "Holstebro", "Taastrup",
            "Slagelse", "Hillerød", "Holbæk", "Sønderborg", "Svendborg", "Hjørring", "Frederikshavn", "Nørresundby", "Ringsted", "Haderslev", "Ølstykke", "Stenløse", "Skive", "Birkerød" };

        private String[] addresses = { "Primrose Lane", "College Street", "6th Street West", "Queen Street", "Spruce Street", "Chapel Street", "Elm Avenue", "Overlook Circle", "Brook Lane", "Pin Oak Drive", "Sunset Avenue",
            "Andover Court", "Evergreen Lane", "Crescent Street", "Cedar Street", "Jones Street", "Spring Street", "Summit Avenue", "Shady Lane", "East Street", "5th Street East", "Cypress Court", "Cherry Street",
            "School Street", "11th Street", "Delaware Avenue", "Edgewood Road", "6th Avenue", "Charles Street", "Brookside Drive", "Oak Street", "Aspen Drive", "Prospect Street", "Glenwood Avenue", "9th Street West",
            "Oxford Road", "Orange Street", "River Road", "Schoolhouse Lane", "Chestnut Street", "Tanglewood Drive", "Valley Drive", "Pearl Street", "Manor Drive", "Bayberry Drive", "High Street", "Dogwood Lane",
            "Railroad Avenue", "South Street", "Heritage Drive", "Maple Lane", "Valley View Road", "Valley View Drive", "Route 5", "New Street", "12th Street East", "Franklin Street", "Route 7", "Lincoln Avenue",
            "Sherwood Drive", "Highland Drive", "Front Street North", "3rd Street North", "Broad Street", "Monroe Drive", "Route 11", "Jefferson Street", "Evergreen Drive", "Lafayette Avenue", "6th Street North",
            "Colonial Avenue", "Main Street", "Sunset Drive", "Devon Road", "Park Drive", "Bridle Lane", "Ashley Court", "William Street", "4th Avenue", "Oak Avenue", "Walnut Avenue", "Railroad Street", "Bay Street",
            "Eagle Road", "Roberts Road", "Madison Court", "Central Avenue", "Ivy Lane", "4th Street West", "Lexington Drive", "Virginia Avenue", "Lafayette Street", "Main Street West", "Route 6", "Homestead Drive",
            "Elm Street", "York Road", "Forest Avenue", "Route 64", "Grant Avenue" };

        private String[] adjectives = { "able", "abnormal", "absent-minded", "above", "average", "adventurous", "affectionate", "agile", "agreeable", "alert", "amazing", "ambitious", "amiable", "amusing",
            "analytical", "angelic", "apathetic", "apprehensive", "ardent", "artificial", "artistic", "assertive", "attentive", "average", "awesome", "awful", "balanced", "beautiful", "below", "average",
            "beneficent", "blue", "blunt", "boisterous", "brave", "bright", "brilliant", "buff", "callous", "candid", "cantankerous", "capable", "careful", "careless", "caustic", "cautious", "charming",
            "childish", "childlike", "cheerful", "chic", "churlish", "circumspect", "civil", "clean", "clever", "clumsy", "coherent", "cold", "competent", "composed", "conceited", "condescending",
            "confident", "confused", "conscientious", "considerate", "content", "cool", "cool-headed", "cooperative", "cordial", "courageous", "cowardly", "crabby", "crafty", "cranky", "crass",
            "critical", "cruel", "curious", "cynical", "dainty", "decisive", "deep", "deferential", "deft", "delicate", "demonic", "dependent", "delightful", "demure", "depressed", "devoted",
            "dextrous", "diligent", "direct", "dirty", "disagreeable", "discerning" };

        private String[] jobTitles = { "Account Executive", "Administrative Assistant", "Administrative Manager", "Branch Manager", "Business Analyst", "Business Manager", "Chief Executive Officer",
            "Office Manager", "Operations Manager", "Quality Control Coordinator", "Risk Manager", "Service Representative", "Accounts Receivable/Payable Specialist", "Assessor", "Auditor", "Bookkeeper", "Budget Analyst",
            "Cash Manager", "Chief Financial Officer", "Controller", "Credit Manager", "Tax Specialist", "Treasurer", "Certified Financial Planner", "Chartered Wealth Manager", "Credit Analyst", "Credit Manager",
            "Financial Analyst", "Hedge Fund Manager", "Hedge Fund Principal", "Hedge Fund Trader", "Investment Advisor", "Investment Banker", "Investor Relations Officer", "Leveraged Buyout Investor", "Loan Officer",
            "Mortgage Banker", "Mutual Fund Analyst", "Portfolio Management Marketing", "Portfolio Manager", "Ratings Analyst", "Stockbroker", "Trust Officer", "Benefits Officer", "Compensation Analyst",
            "Employee Relations Specialist", "HR Coordinator", "HR Specialist", "Retirement Plan Counselor", "Staffing Consultant", "Union Organizer", "Business Systems Analyst", "Content Manager", "Content Strategist",
            "Database Administrator", "Digital Marketing Manager", "Full Stack Developer", "Information Architect", "Marketing Technologist", "Mobile Developer", "Project Manager", "Social Media Manager", "Software Engineer",
            "Systems Engineer", "Software Developer", "Systems Administrator", "User Interface Specialist", "Web Analytics Developer", "Web Developer", "Webmaster", "Actuary", "Claims Adjuster", "Damage Appraiser",
            "Insurance Adjuster", "Insurance Agent", "Insurance Appraiser", "Insurance Broker", "Insurance Claims Examiner", "Insurance Investigator", "Loss Control Specialist", "Underwriter", "Business Broker",
            "Business Transfer Agent", "Commercial Appraiser", "Commercial Real Estate Agent", "Commercial Real Estate Broker", "Real Estate Appraiser", "Real Estate Officer", "Residential Appraiser",
            "Residential Real Estate Agent", "Residential Real Estate Broker" };

        String[] courses = { "Accounting & Finance", "Aeronautical & Manufacturing Engineering", "Agriculture & Forestry", "American Studies", "Anatomy & Physiology", "Anthropology", "Archaeology",
            "Architecture", "Art & Design", "Aural & Oral Sciences", "Biological Sciences", "Building", "Business & Management Studies", "Celtic Studies", "Chemical Engineering", "Chemistry", "Civil Engineering",
            "Classics & Ancient History", "Communication & Media Studies", "Complementary Medicine", "Computer Science", "Counselling", "Creative Writing", "Criminology", "Dentistry", "Drama, Dance & Cinematics",
            "East & South Asian Studies", "Economics", "Education", "Electrical & Electronic Engineering", "English", "Fashion", "Film Making", "Food Science", "Forensic Science", "French", "Geography & Environmental Sciences",
            "Geology", "General Engineering", "German", "History", "History of Art, Architecture & Design", "Hospitality, Leisure, Recreation & Tourism", "Iberian Languages/Hispanic Studies", "Italian",
            "Land & Property Management", "Law", "Librarianship & Information Management", "Linguistics", "Marketing", "Materials Technology", "Mathematics", "Mechanical Engineering", "Medical Technology",
            "Medicine", "Middle Eastern & African Studies", "Music", "Nursing", "Occupational Therapy", "Optometry, Ophthalmology & Orthoptics", "Pharmacology & Pharmacy", "Philosophy", "Physics and Astronomy",
            "Physiotherapy", "Politics", "Psychology", "Robotics", "Russian & East European Languages", "Social Policy", "Social Work", "Sociology", "Sports Science", "Theology & Religious Studies",
            "Town & Country Planning and Landscape Design", "Veterinary Medicine" };


        private String[] customValues1 = new String[] { "" };
        private String[] customValues2 = new String[] { "" };
        private List<String> remember1 = new List<String>();

        private Random r = new Random();
        private int numberLength;

        public String GetFullName()
        {
            double d = r.NextDouble();
            String name = d > 0.5 ? girlNames[r.Next(0, girlNames.Length)] : boyNames[r.Next(0, boyNames.Length)];
            String family = familyNames[r.Next(0, familyNames.Length)];
            return name + " " + family;
        }

        public String GetDepartment()
        {
            return departments[r.Next(0, departments.Length)];
        }

        public String GetCity()
        {
            return cities[r.Next(0, cities.Length)];
        }

        public String GetAddress()
        {
            return addresses[r.Next(0, addresses.Length)];
        }

        public String GetCountry()
        {
            return "Denmark"; // lel
        }

        public String GetDate()
        {
            int day = r.Next(1, 29);
            int month = r.Next(1, 13);
            return (day < 10 ? "0" + (day).ToString() : day.ToString()) + "/" +
                (month < 10 ? "0" + (month).ToString() : month.ToString()) + "/2018";
        }

        public String GetDescription()
        {
            return adjectives[r.Next(0, adjectives.Length)];
        }

        public String GetJobTitle()
        {
            return jobTitles[r.Next(0, jobTitles.Length)];
        }

        public String GetJobType()
        {
            double d = r.NextDouble();
            return d > 0.5 ? "Proffessional" : "Amateur";
        }

        public String GetCourse()
        {
            return courses[r.Next(0, courses.Length)];
        }

        public String GetNumber()
        {
            if(numberLength > 20 || numberLength < 0)
            {
                numberLength = 20;
            }
            String s = "";
            while(s.Length < numberLength)
            {
                s += r.Next(0, 10).ToString();
            }
            return s;
        }

        public void SetNummberLength(int num)
        {
            numberLength = num;            
        }

        public void AddToCustom1(String values)
        {
            Console.WriteLine(values);
            customValues1 = values.Split(',');
            Console.WriteLine(customValues1);
        }

        public void AddToCustom2(String values)
        {
            customValues2 = values.Split(',');
        }

        public String GetCustomValue1()
        {
            return customValues1[r.Next(0, customValues1.Length)];
        }

        public String GetCustomValue2()
        {
            return customValues2[r.Next(0, customValues2.Length)];
        }

        public void AddToRemember1(String s)
        {
            remember1.Add(s);
        }

        public String GetFromRemember1()
        {
            return (remember1.ElementAt(r.Next(0, remember1.Count)));
        }

    }
}
