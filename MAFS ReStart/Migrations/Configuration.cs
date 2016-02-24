namespace MAFS_ReStart.Migrations
{
    using MAFS_ReStart.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MAFS_ReStart.Models.MafsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MAFS_ReStart.Models.MafsDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            ////LOCATIONS
            ////Chicago Location
            Location Chicago = new Location();
            Chicago.CityName = "Chicago";
            Chicago.Phone = "773-465-3105";
            Chicago.Fax = "773-465-0158";
            Chicago.AddressLine1 = "7541 N Western Ave.";
            Chicago.AddressLine2 = "Chicago, IL 60645";
            Chicago.Zipcode = "60645";
            Chicago.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2964.14438525393!2d-87.6898215!3d42.018634899999995!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x880fd02db1977f7f%3A0xe422c0b61d364c29!2sMetropolitan+Asian+Family+Services!5e0!3m2!1sen!2sus!4v1436212228630"; 

            context.Locations.AddOrUpdate(r => r.CityName, Chicago);


            //Niles Location
            Location Niles = new Location();
            Niles.CityName = "Niles";
            Niles.Phone = "847-824-9414";
            Niles.Fax = "847-824-9415";
            Niles.AddressLine1 = "9015 N Milwaukee Ave.";
            Niles.AddressLine2 = "Niles, IL 60714";
            Niles.Zipcode = "60714";
            Niles.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d11851.661605083538!2d-87.8295208!3d42.0449944!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x3db3ac4b293c396e!2sMetropolitan+Asian+Family+Services!5e0!3m2!1sen!2sus!4v1456172323587";

            context.Locations.AddOrUpdate(r => r.CityName, Niles);

            //Naperville Location
            Location Naperville = new Location();
            Naperville.CityName = "Naperville";
            Naperville.Phone = "630-705-1208";
            Naperville.Fax = "630-470-6038";    //check
            Naperville.AddressLine1 = "1032 E Ogden Ave.";
            Naperville.AddressLine2 = "Naperville, IL. 60563";
            Naperville.Zipcode = "60563";
            Naperville.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2974.7235398463877!2d-88.13146788456163!3d41.79117137922919!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x880e56561e7fcdcf%3A0x53c50b4a6daaef74!2s1032+E+Ogden+Ave%2C+Naperville%2C+IL+60563!5e0!3m2!1sen!2sus!4v1456172668691";

            context.Locations.AddOrUpdate(r => r.CityName, Naperville);

            //Roselle Location
            Location Roselle = new Location();
            Roselle.CityName = "Roselle";
            Roselle.Phone = "630-307-6277";
            Roselle.Fax = "630-307-6477";
            Roselle.AddressLine1 = "127 E Main Street";
            Roselle.AddressLine2 = "Roselle, IL. 60172";
            Roselle.Zipcode = "60172";
            Roselle.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11863.185928210572!2d-88.07624263806179!3d41.98317916619724!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xc8f91e3dcae034f8!2sMetropolitan+Asian+Family+Services!5e0!3m2!1sen!2sus!4v1456172798900";

            context.Locations.AddOrUpdate(r => r.CityName, Roselle);

            //CAROL STREAM Location
            Location CarolStream = new Location();
            CarolStream.CityName = "Carol Stream";
            CarolStream.Phone = "224-208-1130";
            CarolStream.Fax = "224-208-1131";
            CarolStream.AddressLine1 = "954 W Army Trail Road";
            CarolStream.AddressLine2 = "Carol Stream, IL. 60188";
            CarolStream.Zipcode = "60188";
            CarolStream.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11871.097892132117!2d-88.15198115331714!3d41.94069730229506!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x869c0a0f32d6057a!2sUniversal+Metro+Asian+Services!5e0!3m2!1sen!2sus!4v1456175632059";

            context.Locations.AddOrUpdate(r => r.CityName, CarolStream);

            //Vernon Hills Location
            Location VernonHills = new Location();
            VernonHills.CityName = "Vernon Hills";
            VernonHills.Phone = "224-333-3200";
            VernonHills.Fax = "224-333-3303";
            VernonHills.AddressLine1 = "2779 W Algonquin Rd, Unit # 2713";
            VernonHills.AddressLine2 = "Algonquin, IL. 60102";
            VernonHills.Zipcode = "60102";
            VernonHills.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2956.8147592370565!2d-88.34376348454953!3d42.17564377919978!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x880f1267ce7ba37f%3A0xe9abcb173ea1ab9f!2s2779+W+Algonquin+Rd%2C+Lake+in+the+Hills%2C+IL+60102!5e0!3m2!1sen!2sus!4v1456175772857";

            context.Locations.AddOrUpdate(r => r.CityName, VernonHills);

            //Orland Park Location
            Location OrlandPark = new Location();
            OrlandPark.CityName = "Orland Park";
            OrlandPark.Phone = "708-675-1980";
            OrlandPark.Fax = "708-675-1988";
            OrlandPark.AddressLine1 = "11225 W 159th Street";
            OrlandPark.AddressLine2 = "Orland Park, IL. 60467";
            OrlandPark.Zipcode = "60467";
            OrlandPark.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d11934.49087816408!2d-87.892459!3d41.599044!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xa20f0693fd9c6ace!2sMetropolitan+Asian+Family+Services!5e0!3m2!1sen!2sus!4v1456175859890";

            context.Locations.AddOrUpdate(r => r.CityName, OrlandPark);

            //Elgin Location
            Location Elgin = new Location();
            Elgin.CityName = "Elgin";
            Elgin.Phone = "224-333-3200";   //change
            Elgin.Fax = "224-333-3303";     //change
            Elgin.AddressLine1 = "700 W Bowes Rd";  //add suite?
            Elgin.AddressLine2 = "Elgin, IL. 60177";
            Elgin.Zipcode = "60177";
            Elgin.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2964.689335894357!2d-88.31728038455489!3d42.006942379212155!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x880f1b0a5b602759%3A0x9bf79a3995f3cd66!2sBowes+Rd%2C+Elgin+Township%2C+IL!5e0!3m2!1sen!2sus!4v1456175972926";

            context.Locations.AddOrUpdate(r => r.CityName, Elgin);

            //Northlake Location
            Location Northlake = new Location();
            Northlake.CityName = "Northlake";
            Northlake.Phone = "224-817-2590";
            Northlake.Fax = "224-333-3303"; //change
            Northlake.AddressLine1 = "50 E North Ave";
            Northlake.AddressLine2 = "Northlake, IL 60164";
            Northlake.Zipcode = "60164";
            Northlake.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2969.31731620674!2d-87.90299818455799!3d41.90753687921988!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x880fb4d11baf0adb%3A0x97d0703d556e112e!2s50+E+North+Ave%2C+Northlake%2C+IL+60164!5e0!3m2!1sen!2sus!4v1456176068103";

            context.Locations.AddOrUpdate(r => r.CityName, Northlake);

            //FUNDING AGENCY
            //AgeOptions
            FundingAgency AgeOptions = new FundingAgency();
            AgeOptions.Name = "AgeOptions";
            AgeOptions.URL = "http://www.ageoptions.org/";
            AgeOptions.ImageURL = "images/funders/ageoptions.png";
            AgeOptions.ShortBio = "AgeOptions is a nonprofit organization connecting older adults and those who care for them with resources and service options so they can live their lives to the fullest. Since 1974, our mission has been to sustain and promote independence for older persons in their own homes and communities. As the Area Agency on Aging of suburban Cook County, Illinois, we advocate, plan, coordinate and fund services for older adults. Together with a network of community-based senior service organizations, we connect residents with vital services such as information and assistance, community dining programs and home-delivered meals, housekeeping help, employment services, access to benefits and support for family caregivers.";
            context.Funders.AddOrUpdate(r => r.Name, AgeOptions);

            //Northwestern
            FundingAgency Northwestern = new FundingAgency();
            Northwestern.Name = "Northwestern University Fienberg School of Medicine";
            Northwestern.URL = "http://www.feinberg.northwestern.edu/sites/cch/funding/seed-grants/arcc/partner-award-recipient.html";
            Northwestern.ImageURL = "images/funders/NW_Feinberg.jpg";
            Northwestern.ShortBio = "The seed grant program offered through the Alliance for Research in Chicagoland Communities (ARCC) is one of several sponsored by NUCATS and the IPHAM Center for Community Health. This seed grant program seeks to: Increase the number and build the capacity of community-engaged research partnerships and projects between Chicagoland communities and Northwestern University academic teams"
+ " Foster the development of community-engaged research proposals for external funding"
+ " Support the dissemination and implementation of research findings in communities that contribute to community health.";
            context.Funders.AddOrUpdate(r => r.Name, Northwestern);

            //CLESE
            FundingAgency Clese = new FundingAgency();
            Clese.Name = "CLESE";
            Clese.URL = "http://clese.org/";
            Clese.ImageURL = "images/funders/Clese.png";
            Clese.ShortBio = "CLESE is committed to a vision of equal access to services for all elderly, regardless of ethnicity or language. As a coalition, CLESE works to increase awareness of the needs, rights, and unique contributions of limited-English-speaking elderly and the community-based organizations that serve them. CLESE promotes understanding, sensitivity, and insight into culturally diverse communities. CLESE is a resource to ethnic agencies by providing assistance and information. Fifty four community-based ethnic organizations can be reached by contacting CLESE.";
            context.Funders.AddOrUpdate(r => r.Name, Clese);

            //Ceda
            FundingAgency Ceda = new FundingAgency();
            Ceda.Name = "CEDA";
            Ceda.URL = "http://www.cedaorg.net/www2/EnergyAssistance.html";
            Ceda.ImageURL = "images/funders/ceda.png";
            Ceda.ShortBio = "Low Income Home Energy Assistance Program (LIHEAP) is designed to assist income-eligible households with energy services, in the form of a one-time benefit payment to the utility companies that is applied directly to the household’s energy bills. The amount of the payment is determined by income, household size, and fuel type. Please call the Energy Services Hotline for more information.";
            context.Funders.AddOrUpdate(r => r.Name, Ceda);

            //CityOfChicago

            //Jesse White

            FundingAgency Jesse = new FundingAgency();
            Jesse.Name = "Jesse White, Secretary of State";
            Jesse.URL = "https://www.cyberdriveillinois.com/departments/library/literacy/home.html";
            Jesse.ImageURL = "images/funders/SecOfStateJesseWhite.png";
            Jesse.ShortBio = "The Illinois State Library and Secretary of State and State Librarian Jesse White are committed to providing adult literacy program services that will enable Illinois citizens to fully participate in their family, work and community roles. To this end, the State Library's Literacy Office administers the Adult Literacy grant programs that provide basic adult literacy instruction to enhance reading, writing, math or English proficiency for the targeted program participants.";
            context.Funders.AddOrUpdate(r => r.Name, Jesse);

            //Asian Health Coalation
            FundingAgency AHC = new FundingAgency();
            AHC.Name = "Asian Health Coalation";
            AHC.URL = "http://www.asianhealth.org/the-issues/cancer/breast-and-cervical-cancer/";
            AHC.ImageURL = "images/funders/asian-health-coalition.png";
            AHC.ShortBio = "The PINK PASHMINA PROJECT program targets highly vulnerable Muslim American and South Asian immigrant women residing in ethnic enclave in greater Chicagoland to reduce disparities and increase awareness and screening rates. The program aims to raise their awareness in a culturally competent fashion about breast and cervical cancer risks and prevention as well as providing them with linkages to care to guide them through the health care system for screenings and proper timely care. The Pink Pashmina Project is funded in 2014-2015 by the Susan G. Komen Foundation, Chicago Foundation for Women, Lesser Franklin Charitable Trust and Crown Family Philanthropies.";
            context.Funders.AddOrUpdate(r => r.Name, AHC);


             
            context.Restaurants.AddOrUpdate(r => r.Name,new Restaurant {Name = "Public House", City = "Chicago", Country = "USA" });

            //for (int i = 0; i < 1000; i++ )
            //{
            //    context.Restaurants.AddOrUpdate(r => r.Name,
            //        new Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
            //}

            //Seed database with Board of Directors
            //Dr. Jafri
            context.Members.AddOrUpdate(r => r.FirstName, new Member { 
                FirstName = "Firdaus", 
                LastName = "Jafri",
                Position = "President",
                Bio = "is an accomplished dentist with her own practice in Carol Stream, IL. She is currently the President of MAFS. She also serves as a member of the Research Committee of American Academy of Implant Dentistry, International Congress of Oral Implantologists and the American Dental Association. Her passion for humanitarian efforts, especially for Indian Americans, is manifested through her dedication to multiple organizations in order to help them achieve their goals. Dr. Jafri has brought many active members to MAFS since she joined, which has enriched MAFS with great advocacy, leadership, and insight into the problems that face immigrants." ,
                Image = "Firdaus-Jafri.png",
                Image2 = "Firdaus-Jafri2.gif",
                IsStaff = false,
                IsActive = true,
                Facebook = @"https://www.facebook.com/pages/Jafri-Firdaus-DDS-Assoc-DBA-Dupage-Dental-Care/139251229455874",
                Email = "a2thrx@yahoo.com",
                LinkedIn = string.Empty

            });
            //Naren Patel
            
            context.Members.AddOrUpdate(r => r.FirstName, new Member { 
                FirstName = "Naren", 
                LastName = "Patel",
                Position = "Vice President",
                Bio = "is the owner, CEO and President of MedStar Laboratory, Inc., located in Hillside, IL. Naren graduated as a Pharmacist from Gujarat State University in 1969. Since coming to the US, he has acquired and opened medical centers in the Greater Chicagoland area. Mr. Patel is the founder and President of Vishwa Gujarati Samaj-USA, also serves as the President of Care & Share USA International and also served as the past President of Six Gam Patidar Samaj and AIA. Through his leadership, Care & Share was able to build 25 homes for displaced Tsunami Victims in India. He is the National Vice President of the Association of Indian American Medical Association Charitable Foundation and serves as a Director on the MAFS board. Naren Patel is a well-known personality and believes in giving back to the community. This year, under his leadership, VGS-USA is celebrating Honorable Prime Minister Narendra Modi's Victory Party with many Indian Organizations in Chicgoland area." ,
                Image = "Naren-Patel.png",
                Image2 = "Naren-Patel2.png",
                IsStaff = false,
                IsActive = false
            });
            //Pramod Kumar
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Pramod",
                LastName = "Kumar",
                Position = "Treasurer",
                Bio = "is a mechanical engineer by profession and an accomplished businessman with over 30 years of experience. His knowledge and expertise has launched many entrepreneurial projects and supports charitable efforts. Mr. Kumar was recognized by the National Register’s Who’s Who of Executive Professionals. He is an active board member and provides constant support to continue MAFS mission.  He continuously brings new resources to expand MAFS and make them accessible to more suburban communities in the greater Chicagoland area.",
                Image = "Pramod-Kumar.png",
                Image2 = "Pramod-Kumar2.png",
                IsStaff = false,
                IsActive = true,
                Facebook = @"https://www.facebook.com/pramod.kumar.9862",
                Email = "pramodk@umasinc.com",
                LinkedIn = @"https://www.linkedin.com/in/pramod-kumar-24a9a626"
            });
            //Beena Patel
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Beena",
                LastName = "Patel",
                Position = "Secretary",
                Bio = "was born and raised in Gujarat, India. She earned her master's degree in Commerce. She began her career in India with the Gujarat Electricity Board as an intern and then full time employment with Dena Bank and State Bank of India. Mrs. Patel married Dixit Patel 30 years ago and moved to the US to start their new adventure and life. Upon her arrival to the US, she began her career as the Clerk of the Circuit Court of Cook County Traffic Division in 1987 and at present working as the Associate Clerk of the First Municipal Bureau. In 2000, Mrs. Patel and another co-worker formed the \"Clerk of the Circuit Court of Cook County Asian American Employees Social Club.\" Mrs. Patel is a dedicated and avid community organizer. She belongs to many political, cultural and social organizations.   Her memberships are as follows:  Board Member of the Indian American Medical Association Charitable Foundation \"IAMACF\"; Metropolitan Asian Family Services; Vice President of the Association of Indians in America “AIA” Board Member of the Vishwa Gujarati Samaj USA; Brand Ambassador to India Abroad \"Save the Child Girl\" Member of the Desi Divas Book Club; and the Hindi Lovers Club.",
                Image = "Beena-Patel.png",
                Image2 = "Beena-Patel2.gif",
                IsStaff = false,
                IsActive = true,
                Facebook = string.Empty,
                Email = "beenapate@gmail.com",
                LinkedIn = @"https://www.linkedin.com/in/beena-patel-4279145a"

            });
            //Nikunj Baxi
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Nikunj",
                LastName = "Baxi",
                Position = "Board Member",
                Bio = "has a bachelors degree in Chemistry and currently holds a managerial position at a pharmaceutical company in Chicago. His passion is social work and helping the community. Nick is a young, energetic community activist. He served as the President of Gujarati Samaj of Chicago, one of the oldest and very reputable organizations to date. He has also served as the Director for FIA and the Ribbon Foundation. Nick remains connected with the Gujarati community and continues to serve the Indian American community in various ways.",
                Image = "Nikunj-Baxi.png",
                Image2 = "Nikunj-Baxi2.gif",
                IsStaff = false,
                IsActive = true,
                Facebook = string.Empty,
                Email = "nbaxi00@hotmail.com",
                LinkedIn = string.Empty
            });
            //Rakesh Asthana
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Rakesh",
                LastName = "Asthana",
                Position = "Board Member",
                Bio = "is a veterinarian by education and is a retired Major of the Indian army. After having practiced for nearly eighteen years as a veterinarian with the Indian Army, he was seconded to the Kuwaiti Army for two years. After having migrated to the US in 1993, Dr. Asthana has worked as a Cardiovascular Specialist, with various pharmaceutical companies like Parke-Davis, Pfizer, Glaxo, Novartis, and Astra Zeneca. He currently works as a \"Senior Cardiovascular Specialist\" with the Japanese Pharmaceutical company Daiichi-Sankyo US.  He tirelessly volunteers in various not-for-profit organizations. He sits on the Board of Directors of Black Feet Volunteer Medical Corps (BVMC). Rakesh also volunteers his time with \"Young Hearts 4 Life\", a stellar organization, screening young high school children in the US to avoid \"Sudden Cardiac Death\" syndrome. Rakesh firmly believes that the elderly and senior citizens in the US need our help and that MAFS is doing commendable work, which should be whole-heartedly supported.",
                Image = "Rakesh-Asthana.png",
                Image2 = "Rakesh-Asthana2.gif",
                IsStaff = false,
                IsActive = true,
                Facebook = @"https://www.facebook.com/rakesh.asthana.98",
                Email = "rocky9550@yahoo.com",
                LinkedIn = @"https://www.linkedin.com/in/rakesh-asthana-76353a10"
            }); 
             //Sumitra Patel
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Sumitra",
                LastName = "Patel",
                Position = "Board Member",
                Bio = "Born in Ahmedabad, India, Sumitra grew up in Sabarmati, where Mahatma Gandhi lived in the later part of his life.  Sumitra now resides in Schaumburg, Illinois, with her sister Hansa.  She has two sons, Neal and Raj.  Neal, is married to Sonal, and they have two children, Nishal (19) and Shriya (12).  Raj is married to Nisha, and they have two sons, Ronak (12) and Raveen (9). Sumitra graduated with a degree in phycology from Gujarat College in 1969.  Her move to the US in January of 1970 marked the beginning of her family life in Chicago.  Sumitra’s first professional position in the Little Fuse Company was as the Quality Control Supervisor.  She retired after 35 years in May 2006, and now spending time with her 4 Grandchildren. She has received numerous awards. Jesse Jackson’s Rainbow Push Organizations awarded her as the Best Mother in 2010 and New Millennium Women of Dorothy Brown’s Organization presented her “Woman of the New Millennium Award” in 2011. Sumitra  is a staunch supporter of Metropolitan Asian Family Services and joined MAFS in January 2015. A devoted Hindu, Sumitra is a strong believer of his Holiness Pujya Pramukhswami Maharaj of BAPS.",
                Image = "Sumitra-Patel.png",
                Image2 = "Sumitra-Patel2.gif",
                IsStaff = false,
                IsActive = true,
                Facebook = string.Empty,
                Email = string.Empty,
                LinkedIn = string.Empty
            });

            //Shweta Singh
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Shweta",
                LastName = "Singh",
                Position = "Board Member",
                Bio = "is an Associate Professor at the School of Social Work at Loyola University Chicago. Her M.S.W. is from the Tata Institute of Social Sciences at Mumbai, India and her Doctorate is from the University of North Carolina at Chapel Hill, USA. Singh is the instructor for courses on research and evaluation, global feminism, and nonprofit management. Her previous research work includes consultancies assisting field offices based in India of international development agencies such as, UNICEF, OXFAM, and local NGOs on evaluation research projects. Her research is on empowerment for women and girls using a holistic identity context. Her work includes audio-video documentary for clinical intervention and policy advocacy. Her edited book is called Social Work and Social Development: Perspectives from India and the United Sates published by Lyceum Chicago. She has also produced a documentary titled Urban Indian Womanhood. She also hosts a radio show on WLUW called ‘Global desi World and Women’ that caters to immigrant South Asian women.",
                Image = "Shweta-Singh.png",
                Image2 = "Shweta-Singh.gif",
                IsStaff = false,
                IsActive = true,
                Facebook = @"https://www.facebook.com/1ShwetaSingh",
                Email = string.Empty,
                LinkedIn = @"https://www.linkedin.com/in/shweta-singh-a7004714"
            });
             
            //Seed Fundraiser
            //2014
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2014, 9, 13),
                IsMini = false,
                Location = "Schaumburg, IL",
                Venue = "India House",
                Intro = "Metropolitan Asian Family Services' celebrated its 22nd annual fundraising dinner with excitement, entertainment and an award ceremony on September 13, 2014 at India House, Schaumburg, Illinois.",
                WriteUp = "The celebration started with a traditional deep lightning ceremony performed by  Pt. Choodaman Pathak of Radhey Shyam Temple and was followed by a Ganesh Vandana dance performance by students of the Mudra Dance Academy. Prominent dignitaries in attendance were Toni Preckwinkle, Cook County Board President, Paul Vallas, Democratic Lt. Governor Candidate, Dr. Ausaf Sayeed, Consul General of India, Chicago, Rep. Michelle Mussman, Gayle A. Smolinski, Roselle Mayor, Rodney S. Craig, Hanover Park Mayor, Dr. Hemlata Bakane, President of IAMA, Sonia Bhagwakar from IDOA, Sher Mohammad Rajput, Indo American Center Board Member, Nand Kapoor, former President Association of Indian in America, Anees Chaudhary, Treasurer of the AMU Alumni Association of Greater Chicago, and other community leaders and business supporters including seniors  and their families. Dr. Ausaf Sayeed, Consul General of India, commended the MAFS team for doing an extraordinary job in serving and caring for the elderly and other immigrant populations in Chicagoland. ",
                CoverPhoto = "Fundraiser/2014.jpg",
                IssuuLink = "9480861/11710604",
                FlickrGallery = ""
            });
            /*  2015 Mini WriteUp = "The celebration started with the diya ceremony which was performed by Swami Purnatmanandaji of Bharat Sevashram of Chicago. Prominent leaders in attendance were Gopal Lalmalani, Village President Oak Brook, Mayor George Pradel, Ex- Naperville Mayor, Nakul Singh Chand, Regional Manager, Air India, Nimish Jani, Villlage Trustee Schaumburg, Krishna Bansal, Outreach Coordinator Naperville Village, and MAFS board members. In his opening remarks our keynote speaker, Mayor Lalmalani, commended the MAFS team for serving the community on all fronts for over 3 decades. He congratulated the MAFS team for opening new location at Schaumburg and expressed his concern on recent budget cut. Similar remarks of concern were presented by Mr. Bansal, he urged community to come forward and join in MAFS mission of serving and caring. "
+ "Mrs. Kumar presented a detailed annual report. She said that the requirement for all our Nutrition, Public Benefit and Health Research and education related programs are to raise matching funds from our community and urged all those in attendance to understand the facts and come forward to support these programs. " 
+ "Ms. Beena Patel, MAFS Secretary expressed her concern on recent budget cut. Ms. Patel read out all our lobbying efforts to save Community Care and Adult Day Care Services. Our guest speaker Mayor George Pradel boosted everyone spirit with his vigor and energy. "
+ "The program started with Ganesh Vandana by Radhika Akolkar of the Radhika Dance Academy. Our Carol Stream seniors presented a very fascinating and well-balanced Tippani Dance performance. "
+ "Our Naperville staff and seniors presented a historical dance performance from the city of Gujarat called RAAS but it was our Chicago seniors under the guidance of Pankaj Patel, ADS Coordinator, that stole the show with their superb performance. "
+ "Mandi Theater of Chicago presented a hilarious drama called as Udan Khatola performed by Jagmohan Rawat, Rohit Sharma and Alka Sharma. "
+ "The celebration also had an award ceremony. Gopal Lalmalani was given the Community Service Award; Mayor George Pradel was given the Support Service Award. Appreciation Awards were given to Nimish Jani, Krishna Bansal and Nakul Singh Chand. "
+ "Our emcees Neelam Desai, Naperville Manager and Jahnavi Bavisi, Niles Manager successfully managed the entire program and the event was concluded with vegetarian dinner which prepared by our kitchen. Beena Patel has presented vote of thanks. ",*/
            //2013
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2013,9,21),
                IsMini = false,
                Location = "Schaumburg, IL",
                Venue = "India House",
                Intro = "People were awe struck, when they saw illusionary tricks of world famous magician, Dennis Watkins at the Metropolitan Asian Family Services annual fund raiser dinner to cover the gaps in State, Federal and local funding . MAFS is a not-for profit organization that provides an array of services to promote the well-being of South Asian immigrants celebrated 21 years of community service on September 21st, at India House Schaumburg. ",
                WriteUp = "The program was started by the lightening of auspicious \"Deep\" by Kusumben Patel, Founder of Global Gayatri, followed by Ganesh-vandana prayer dance by Catherine Jafri and her group and welcome address of Dr. Firdaus Jafri, president MAFS. In his keynote remark, Bill Foster, US Congressman commended the vision and mission of MAFS’s and reaffirmed the commitment of his Democratic Party to welfare programs and reformation of immigration law to give immigrant sensible policy. "
                + "Guest speaker Husain Dalwai, Member of Parliament Upper House (Rajya Sabha), lauded MAFS for doing a noble job in human welfare and for lessening the pangs of old age. Dalwai spoke on various programs that Government of India has initiated to remove this problem and said that we have to look MAFS as a role model in serving and enriching the community without any discrimination to origin, cast, creed and religion. "
 + "Hon’le Consul General Chicago, Dr. Ausaf  Sayeed  praised Mrs. Santosh Kumar &, MAFS for persistently serving community with its various programs, since 1992. "
+ "Mary Killough, Deputy Director, IDOA, remarks, that it is her 4th year to attend the function and every time she amazed with number of people, and programs MAFS serve and growing to meet the increased needs of its community, despite shrinking of state and federal funding for social services."
+ "Other prominent dignitaries present is Mr. Michael Gelder-Health  Policy Advisor to the Governor Pat Quinn, Marta Pereyra, Executive Director CLESE, William D McLead –Mayor Hoffman Estates, Michelle Mussman – State Rep. 56th district, Jonathan Levin – CEO, AgeOptions, Billie Roth, Mayor of Streamwood,  Sajid Desai, businessman, Balvinder Singh – Community leader and social activist, Ms. Gurubachan Kaur, president Hindi Lover Club, Ram Saini, President of Rajasthan Association, Nand Kapoor, past president Association of Indian in America, Sher Rajput, Board member Indo-American Center, A. Anees, Board member of Aligargh Muslim University, Sadruddin Noorani, Jamat Khana. "
+ "This year the “Making a Difference in the world award,” was given to Dr. Joseph Marek, MD, for his cardiac screening program designed to identify high school and college students at risk for sudden cardiac death. Public Service Award was conferred on Husain Dalwai, Indian Member of Parliament (MP), for being an engine of social, political, industrial progress, and his work with tribal, Dalit, and minority communities. The Best Employee of the Year Award given to Afaan Muhammad, IT Manager and Jahnavi Bavisi, Manager Niles branch. Best Supervisor award was given to Smitesh Shah, supervisor and Public Benefit Award was given to Shree Gurusamy, SOS specialist.",
                CoverPhoto = "Fundraiser/2013.jpg",
                IssuuLink = "9480861/30275437",
                FlickrGallery = ""
            }); 
            //2012
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2012,9,22),
                IsMini = false,
                Location = "Rolling Meadows, IL",
                Venue = "Meadows Club",
                Intro = "We celebrated our 20th Anniversary at our annual fundraiser held on September 22, 2013 at Meadows Club, Rolling Meadows.",
                WriteUp = "The annual dinner, hosted in association with Dhrishti, attracted a host of eminent business and community leaders including Jesse White, Illinois Secretary of State, Michael Gelder, Policy Advisor to Governor Pat Quinn, Gopal Lalmalani, MD, Village President Oakbrook, Michelle Mussman, State Representative 56th District, Mayor William McLeod, Hoffman Estates, Mary Killough, Senior Health Care Policy Advisor to Governor Pat Quinn, Marta Pareyra, Executive Director of the Coalition of Limited English Speaking Elderly (CLESE), Jamie Boyce from AgeOptions, and foreign ministers Amrish Singh Gautam, Deputy Speaker Delhi Vidhan Sabha and Karan Singh Pawar, King of Dhar, Madhya Pradesh, India. "
+ "Jesse White, in his remarks, congratulated our staff, board members, and clients for serving the community with compassionate care and passion. He said, \"The range of service that MAFS provides has helped individuals to live fuller and healthier lives.\""
+ "Gelder appreciated Mrs. Kumar for taking the mission and service of MAFS to the next level. He also congratulated MAFS for providing comprehensive and integrated services to the elderly immigrant population in Chicago and greater the Chicago area. "
+ "Mrs. Kumar thanked government organizations and sponsors for supporting various programs of MAFS. She extended her appreciation for our longtime supporters, S.S. Bhatt and Dr. Firdaus Jafri. Speaking on various services that MAFS renders to the community, she said, \"MAFS has started many programs when and where required.  MAFS has been successfully organizing various programs with little or no funding.\""
+ "Celebrating twenty years of success, Mrs. Kumar couldn't help but express her emotions as she spoke of the difficulties she faced and sacrifices that she had made as a mother and wife to benefit those who are less fortunate.  In her closing remarks, Mrs. Kumar said, \"Life is worth living for all of us, thanks to your extraordinary contribution to this cause.\""
+ "Amrish Singh Gautam said he felt proud to see Indian Americans doing such noble deeds in the USA. He urged them to follow the path of Mahatma Gandhi, Pandit Jawahar Lal Nehru, Guru Nanak, Sri Krishna and Sri Ram. Karan Singh Pawar commended MAFS for providing remarkable service to the Indian community in Chicago. "
+ "Part of the evening's entertainment was a Kuchipudi dance program Puspanjali  performed as a fusion dance, a true exhibition of the blending between Eastern and Western culture. "
+ "The much anticipated main entertainment of the night was Amit and Smeet Kumar's tribute to their legendary father Kishore Kumar.  Kishore Kumar was a humorous actor and singer. This performance was enjoyed by guests of all ages as the singers performed old classics with new favorites. "
+ "The audience was treated to some humorous clippings from movies of the legendary star. This was followed by the entrance of the two Kishores, Amit & Sumeet Kumar, who staged a remarkable performance. "
+ "The evening was emceed by Masala T and over $100,350 was raised for the cause!",
                CoverPhoto = "Fundraiser/2012.jpg",
                IssuuLink = "9480861/32475518",
                FlickrGallery = ""
            });
            //2014 Mini
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2014, 5, 31),
                IsMini = true,
                Location = "Naperville, IL",
                Venue = "MAFS Naperville",
                Intro = "It was cross-border love and harmony that marked Metropolitan Asian Family Services’ Asian Heritage Month and Mini Fundraising Gala dinner on May 31st, 2014 at our Naperville Senior Center located at 1032 E Ogden Ave.",
                WriteUp = "Keynote speaker, Ms. Dorothy Miaso, Executive Director of Literacy Volunteers of America, IL informed the crowd how Mrs. Santosh Kumar’s philanthropic nature helped Literacy Volunteers of America with her time, skills and resources 25 years ago as a Vista Volunteer even though she newly immigrated to the United Stated at that time. She also gave her legal skills to shape an after school program for women inmate in Dwight Women Prison to meet and help their children while they are waiting for trial or acquittal. "+

"Chief Guest, the Honorable Ausaf Sayeed, Consul General of India in Chicago graced the occasion with his wife and states that he is very impressed with the plethora of social services provided by MAFS to the immigrant population of India and its neighboring countries.  He extended his blessing and support to the MAFS and Mr. &Mrs. Kumar in serving the community on all fronts. George Pradel, Napverille Mayor congratulated the MAFS team for doing great work for the immigrant population in Naperville. "+

"Krishna Bansal, Chairman for the Indian Community Outreach Mayor’s Office City of Naperville, congratulated MAFS team for providing much needed services to the community. "+

"Other prominent dignitaries that attended were Stephanie Kifowit State Rep, 84th District, George Pradel, Naperville Mayor, Laurie Nowak, Du Page  – Distrcit 5, Bob Peickert- Chair, Democratic Party of Du Page County, Nasir Jahangir- 2nd Chair Democratic Party of Du Page County, Paul Fessenbecker DPDC 3rd chair, Sarbani Chowdhury- Co chair of DPDC women and minority committee, Jean  Kaczmarek Candidate for Du Page County Clerk, Mike Quiroz- Candidate for Du Page County Clerk and MAFS board members. "+

"Pooja and Radha Thakrar, mesmerized everyone with their Bollywood dance performances. The seniors of Chicago performed a very entertaining and engaging skit named Atut Shraddha. Seniors from the Niles location presented “Kahani Ghar Ghar Ki”. Naperville seniors fascinated everyone with “Medley Dance”. Chalte Chalte, another classical Bollywood dance, was performed by the Naperville and Carol Stream seniors. Bipinchandra Sanghavi, a Carol Stream senior, left few eyes dry with his songs. "+

"The greatest attraction of the evening was Shyam E Bahaar – A Musical Show by Swar Sarita, music group from Bombay, India. The singers were Samsuddin Vaghela, Madhuri Goswami, and Kunal Mahant who were accompanied by musicians, Jayesh Raval and Pankaj Raval. They enthralled everyone with pulsating Bollywood numbers and also mesmerized all with a variety of nostalgic, old songs.",
                CoverPhoto = "Fundraiser/2014-mini.jpg",
                FlickrGallery = ""
            }); 

            //2015 Mini
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2015, 6, 13),
                IsMini = true,
                Location = "Naperville, IL",
                Venue = "MAFS Naperville",
                Intro = "300 seniors and prominent community members attended Metropolitan Asian Family Service’s Mini Fundraising dinner on June 13, 2015 at 1032 E Ogden Ave, Naperville, IL.",
                WriteUp = "In his opening remarks our keynote speaker, Mayor Lalmalani, commended the MAFS team for serving the community on all fronts for over 3 decades. He congratulated the MAFS team for opening new location at Schaumburg and expressed his concern on recent budget cut. Similar remarks of concern were presented by Mr. Bansal, he urged community to come forward and join in MAFS mission of serving and caring. "+
" Mrs. Kumar presented a detailed annual report. She said that the requirement for all our Nutrition, Public Benefit and Health Research and education related programs are to raise matching funds from our community and urged all those in attendance to understand the facts and come forward to support these programs. "+
" Ms. Beena Patel, MAFS Secretary expressed her concern on recent budget cut. Ms. Patel read out all our lobbying efforts to save Community Care and Adult Day Care Services. Our guest speaker Mayor George Pradel boosted everyone spirit with his vigor and energy. " + 
" The program started with Ganesh Vandana by Radhika Akolkar of the Radhika Dance Academy. Our Carol Stream seniors presented a very fascinating and well-balanced Tippani Dance performance.  "+
" Our Naperville staff and seniors presented a historical dance performance from the city of Gujarat called RAAS but it was our Chicago seniors under the guidance of Pankaj Patel, ADS Coordinator, that stole the show with their superb performance. "+
" Mandi Theater of Chicago presented a hilarious drama called as Udan Khatola performed by Jagmohan Rawat, Rohit Sharma and Alka Sharma. "+
" The celebration also had an award ceremony. Gopal Lalmalani was given the Community Service Award; Mayor George Pradel was given the Support Service Award. Appreciation Awards were given to Nimish Jani, Krishna Bansal and Nakul Singh Chand. "+
" Our emcees Neelam Desai, Naperville Manager and Jahnavi Bavisi, Niles Manager successfully managed the entire program and the event was concluded with vegetarian dinner which prepared by our kitchen. Beena Patel has presented vote of thanks. ",
                CoverPhoto = "Fundraiser/2015-mini.jpg",
                FlickrGallery = ""
            }); 
            

            //Nutrition Program
            Program Nutrition = new Program();
            Nutrition.Title = "Nutrition";
            Nutrition.ShortDescription = "<strong>To eat is a necessity, but to eat intelligently is an art.</strong> Our staff and members strongly believe in this adage. We serve hot, fresh, home-cooked meals that take into account the dietary requirements and traditions of Indians, Pakistanis, and Bangladeshis.";
            Nutrition.Description = " We also help educate participants on choosing the right kind of foods that help prevent & manage diseases like diabetes and hypertension which are common in our culture.    The smell of masala in the kitchen does not only entice one’s appetite, it also brings people together.  Sharing a meal with a group can be the cure seniors need against feelings of social isolation.  So come join us for a meal and tell that joke you know!  MAFS is in its 15th year of serving hot lunches to the senior citizen population. These lunches are nutritionally balanced but more importantly they provide an opportunity for seniors to make friends and socialize to break free from isolation. These meals are freshly prepared by trained cooks under strict hygienic conditions. We provided 33,905 hot meals to the community this year from our Chicago, Niles and Roselle facilities. ";
            Nutrition.BannerImg = "nutrition3.jpg";
            context.Programs.AddOrUpdate(r => r.Title, Nutrition);

            //Public Benefits
            Program PublicBeneifits = new Program();
            PublicBeneifits.Title = "Public-Benefits";
            PublicBeneifits.ShortDescription = "Have you ever wondered what benefits you qualify for? Many people do not know what is available to them.  MAFS can help you understand and apply for benefits you qualify for.";
            PublicBeneifits.Description = "MAFS is a pioneer in providing social services to low-income and underserved populations. The demand for these kinds of services is increasing due to the slow recovery of our economy. MAFS staff assists clients in accessing public benefits available to fit their individual needs. Our staff helps fill-out applications for these services and escorts them to the appropriate public benefit offices such as Department of Human Services or Social Security Administration, Immigration and Naturalization to submit the application and serve as their interpreter. We also translate official forms in Hindi, Urdu, Gujarati, Spanish and Bosnian languages to facilitate the process of applying for benefits. Our staff acts as liaisons between the client and public officials to help our community members get the help and support they require. This year we had the privilege of helping complete 6,225 cases in Cook, Suburban Cook County, DuPage and Lake County.  MAFS can help you understand and apply for benefits like:  + Medicare + Medicaid + Social Security + Access to Care + Citizenship/Immigration + Transportation + Kids Care + SSI Prescription Drug Assistance + Food Stamps  + LIHEAP  + SHIP and many others.  Come in and talk to our friendly staff about your needs and we will try our utmost to help!";
            PublicBeneifits.BannerImg = "ceda.jpg";
            context.Programs.AddOrUpdate(r => r.Title, PublicBeneifits);

            //Education
            Program Education = new Program();
            Education.Title = "Education";
            Education.ShortDescription = "At MAFS we believe in education.";
            Education.Description = "Education and knowledge help you better understand yourself and the world around you. It also helps you obtain a higher paying job. To help educate and train our community we offer educational and technical programs including, English as a Second Language (ESL), Bright Ideas, CPR training, and Computer training";
            Education.BannerImg = "education.jpg";
            context.Programs.AddOrUpdate(r => r.Title, Education);

            //Research
            Program Research = new Program();
            Research.Title = "Research";
            Research.ShortDescription = "We partner with the leading health and educational institutions to explore and study problems that concern our culture the most.";
            Research.Description = "We have collaborated with Northwestern University’s Feinberg School of Medicine to teach the South Asian community how to make important dietary changes, engage in an active lifestyle, reduce stress, and lose weight to reduce or prevent their chances of stroke and/or heart attacks We also partner with the Asian Health Coalition on two projects. The first is the Pink Pashmina project which offers free breast cancer screenings and mammograms to South Asian woman. The second is to provide our community with free screening and testing for Hepatitis B.";
            Research.BannerImg = "research.jpg";
            context.Programs.AddOrUpdate(r => r.Title, Research);

            //Citizenship
            Program Citizenship = new Program();
            Citizenship.Title = "Citizenship-and-Immigration-Assistance";
            Citizenship.ShortDescription = "Since its establishment, MAFS has, and continues to provide help with the immigration and naturalization process for community members.";
            //more
            Citizenship.Description = "MAFS also helps applicable members of the community in acquiring their Overseas Citizen of India (OCI) card. This year we have helped 160 seniors to fill N.400 for citizenship and I-130 for family petition. This service is provided without outside funding, however, we continue this service to benefit immigrant families. ";
            Citizenship.BannerImg = "immigration.jpg";
            context.Programs.AddOrUpdate(r => r.Title, Citizenship);

            //HealthInsurance
            Program HealthInsurance = new Program();
            HealthInsurance.Title = "Health-Insurance-Assistance";
            //Not the greatest
            HealthInsurance.ShortDescription = " We collaborate with the Asian Health Coalition to assist our community with the Affordable Care Act (Obamacare).";
            //Not the greatest
            HealthInsurance.Description = "Metropolitan Asian Family Services has collaborated with the Asian Health Coalition for assisting our community with the Affordable Care Act also known as Obamacare. It was the state-run outreach and education program offered to all legal residents of Illinois to enroll into Medicaid or Marketplace health insurance. This year our Navigators, Ms. Nazneen Begum and Meenu Jethi, have enrolled over 500 individuals into Medicaid or Marketplace health insurance and reached out to over 1500 people through outreach at temples, mosques, churches and Gurudwaras.";
            HealthInsurance.BannerImg = "obamacare.jpg";
            context.Programs.AddOrUpdate(r => r.Title, HealthInsurance);

            //Blog Posts
            
            context.BlogPosts.AddOrUpdate(r => r.Date, new BlogPost
            {
                Title = "MAFS/UMAS opens senior center with array of services",
                Date = new DateTime(2014, 3, 10),
                Author = "Nazneen Begum",
                Content = "ORLAND PARK: Growing old is not easy, but can be even more difficult for those in need who lack the resources necessary for aging gracefully. Recognizing this growing need of elderly immigrant population in Chicagoland and now in South Suburb, Ms. Santosh Kumar, Executive Director of Metropolitan Asian Family Services (MAFS), decided to launch a new facility in Orland Park and finally had the doors opened on Friday, March 3, at a glittering ceremony.",
                ImgUrl = "http://indiapost.com/wp-content/uploads/2014/03/mafs-2-web.jpg",
                SourceURL = "http://indiapost.com/mafsumas-opens-senior-center-with-array-of-services/"
            });

            context.BlogPosts.AddOrUpdate(r => r.Date, new BlogPost
            {
                Title = "Mrs. Santosh Kumar bestowed the award of “Jewel of Rajasthan”",
                Date = new DateTime(2016, 1, 19),
                Author = "Nazneen Begum",
                Content = "What a proud moment for MAFS family that its founder and Executive Director Mrs. Santosh Kumar was bestowed an award of “Jewel of Rajasthan” leading Indian American personalities. " +
"<p>The official celebration was on 18th Nov, 2015 at Hotel Clarks Amer, Jaipur, sponsored and supported by Manish Media and business fraternity along with Home Minister of Rajasthan Mr. Kataria. A beautiful plaque and coffee table book was offered to Mrs. Kumar for her exemplary accomplishments and for making her motherland proud in the United States. " +
"<p>This award was presented to Mrs. Kumar for her hard work, dedication and determination. Mrs. Kumar through her courageous and smart steps during hardship phase has proved to the world that when there is hardship all that needed is patience, perseverance and focus on goals.",
                ImgUrl = "~/Images/news/jewel-of-india.jpg",
                SourceURL = null,
            });
        }
    }
}
