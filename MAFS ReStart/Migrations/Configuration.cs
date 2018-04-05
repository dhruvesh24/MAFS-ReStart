namespace MAFS_ReStart.Migrations
{
    using MAFS_ReStart.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Security;
using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<MAFS_ReStart.Models.MafsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
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
            VernonHills.Phone = "224-207-5075";
            VernonHills.Fax = "224-207-5076";
            VernonHills.AddressLine1 = "266 Hawthorn Village Commons";
            VernonHills.AddressLine2 = "Vernon Hills, IL. 60061";
            VernonHills.Zipcode = "60061";
            VernonHills.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2953.734440166815!2d-87.96001838454744!3d42.24148607919506!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x880f9641359e2293%3A0x58692a73d30a7ada!2s266+Hawthorn+Village+Commons%2C+Vernon+Hills%2C+IL+60061!5e0!3m2!1sen!2sus!4v1456787598501";

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
            Elgin.Phone = "224-242-7006";  
            Elgin.Fax = "224-224-7008";    
            Elgin.AddressLine1 = "2375 Bowes Rd. Suite 700-800";  
            Elgin.AddressLine2 = "Elgin, IL. 60123";
            Elgin.Zipcode = "60123";
            Elgin.GoogleMap = @"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2964.704099201615!2d-88.33534568455487!3d42.00662557921225!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x880f1b4802f142dd%3A0x1782e536fb71578d!2s2375+Bowes+Rd%2C+Elgin%2C+IL+60123!5e0!3m2!1sen!2sus!4v1456787258085";

            context.Locations.AddOrUpdate(r => r.CityName, Elgin);

            //Northlake Location
            Location Northlake = new Location();
            Northlake.CityName = "Northlake";
            Northlake.Phone = "224-817-2590";
            Northlake.Fax = "708-397-4916";
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
            Ceda.URL = "http://www.cedaorg.net/www2/Energy.html";
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
            AHC.ShortBio = "The agency was founded as the “Asian Health Coalition of Illinois” back in 1996. Up till 1999, it was run by a volunteer Board and gained visibility in the AAPI community for its annual health conferences and health screening fairs targeting low-income, limited-English proficient clients in Chicago. In 1999, the agency was successful in getting a grant from the Illinois Department of Commerce and Cultural Affairs to hire its first full-time Executive Director. Since that time, the agency has shortened its name to the “Asian Health Coalition” or AHC and has streamlined its focus to building strong and innovative health promotion programs in Asian communities throughout the metropolitan Chicago area. Success for AHC in capacity bulding means eventually being able to hand over the programs to the local community organizations once the program reaches a sustainable steady state.";
            context.Funders.AddOrUpdate(r => r.Name, AHC);

            //City of Chicago
            FundingAgency CoC = new FundingAgency();
            CoC.Name = "City of Chicago";
            CoC.URL = "http://www.cityofchicago.org/city/en/ofinterest/res/senior.html";
            CoC.ImageURL = "images/funders/CityOfChicago.png";
            CoC.ShortBio = "Chicago Department of Family and Support Services (\"FSS\") provides a variety of social, educational and recreational activities and programs for the senior community throughout Chicago.  In addition to programming provided by FSS, provided below are links to citywide Services, News, Alerts, and other Supporting Information that may be useful for seniors - provided by departments all across the City.";
            context.Funders.AddOrUpdate(r => r.Name, CoC);

            //DuPage Senior Citizens Council
            FundingAgency DSCC = new FundingAgency();
            DSCC.Name = "DuPage Senior Citizens Council";
            DSCC.URL = "https://www.dupageseniorcouncil.org/";
            DSCC.ImageURL = "images/funders/DSCS.png";
            DSCC.ShortBio = "The DuPage Senior Citizens Council (DSCC) is a not-for-profit 501(c)(3), volunteer driven organization.  Since 1975, DSCC has been providing a variety of programs and services to help seniors live safely in their homes and provide them the opportunity to maintain their well being.  As a proud member of the Meals on Wheels Association of America, DSCC is the Meals on Wheels provider for all of DuPage County. Our Mission: The DuPage Senior Citizens Council initiates, delivers, monitors, and coordinates services that promote the ability of older persons to live their lives in dignity.";
            context.Funders.AddOrUpdate(r => r.Name, DSCC);

            //Medtronic
            FundingAgency Medtronic = new FundingAgency();
            Medtronic.Name = "Medtronic";
            Medtronic.URL = "http://www.medtronic.com/us-en/about/foundation.html";
            Medtronic.ImageURL = "images/funders/Medtronic.png";
            Medtronic.ShortBio = "The Medtronic Foundation focuses on expanding access to healthcare for the underserved worldwide and supporting healthy communities where we live and give. Making the world a healthier place is a lofty goal, especially when barriers to accessing affordable, quality healthcare exist everywhere. But it’s a goal Medtronic takes very seriously. Through the Medtronic Foundation, and our partners and programs, we endeavor to address diverse needs in different parts of the world by: Expanding and improving healthcare access, especially in underserved communities. Enabling patients with chronic illnesses to manage their conditions and use their \"extra life\" to advocate for others in need. Encouraging every one of Medtronic’s 85,000 passionate and generous employees to donate time, skills, and resources to our Foundation-sponsored programs in their communities.";
            context.Funders.AddOrUpdate(r => r.Name, Medtronic);


             
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
                Image2 = "Firdaus-Jafri2.png",
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
                Image2 = "Naren-Patel.png",
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
                IsActive = false,
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
                Image2 = "Beena-Patel2.png",
                IsStaff = false,
                IsActive = false,
                Facebook = @"https://www.facebook.com/beena.patel.9638",
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
                Image2 = "Nikunj-Baxi2.png",
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
                Position = "Secretary",
                Bio = "is a veterinarian by education and is a retired Major of the Indian army. After having practiced for nearly eighteen years as a veterinarian with the Indian Army, he was seconded to the Kuwaiti Army for two years. After having migrated to the US in 1993, Dr. Asthana has worked as a Cardiovascular Specialist, with various pharmaceutical companies like Parke-Davis, Pfizer, Glaxo, Novartis, and Astra Zeneca. He currently works as a \"Senior Cardiovascular Specialist\" with the Japanese Pharmaceutical company Daiichi-Sankyo US.  He tirelessly volunteers in various not-for-profit organizations. He sits on the Board of Directors of Black Feet Volunteer Medical Corps (BVMC). Rakesh also volunteers his time with \"Young Hearts 4 Life\", a stellar organization, screening young high school children in the US to avoid \"Sudden Cardiac Death\" syndrome. Rakesh firmly believes that the elderly and senior citizens in the US need our help and that MAFS is doing commendable work, which should be whole-heartedly supported.",
                Image = "Rakesh-Asthana.png",
                Image2 = "Rakesh-Asthana2.png",
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
                Bio = "was born in Ahmedabad, India, Sumitra grew up in Sabarmati, where Mahatma Gandhi lived in the later part of his life.  Sumitra now resides in Schaumburg, Illinois, with her sister Hansa.  She has two sons, Neal and Raj.  Neal, is married to Sonal, and they have two children, Nishal (19) and Shriya (12).  Raj is married to Nisha, and they have two sons, Ronak (12) and Raveen (9). Sumitra graduated with a degree in phycology from Gujarat College in 1969.  Her move to the US in January of 1970 marked the beginning of her family life in Chicago.  Sumitra’s first professional position in the Little Fuse Company was as the Quality Control Supervisor.  She retired after 35 years in May 2006, and now spending time with her 4 Grandchildren. She has received numerous awards. Jesse Jackson’s Rainbow Push Organizations awarded her as the Best Mother in 2010 and New Millennium Women of Dorothy Brown’s Organization presented her “Woman of the New Millennium Award” in 2011. Sumitra  is a staunch supporter of Metropolitan Asian Family Services and joined MAFS in January 2015. A devoted Hindu, Sumitra is a strong believer of his Holiness Pujya Pramukhswami Maharaj of BAPS.",
                Image = "Sumitra-Patel.png",
                Image2 = "Sumitra-Patel2.png",
                IsStaff = false,
                IsActive = true,
                Facebook = string.Empty,
                Email = "Sumitrapatel@hotmail.com",
                LinkedIn = string.Empty
            });

            //Harish Kolasani
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Harish",
                LastName = "Kolasani",
                Position = "Vice President",
                Bio = "is an individual who serves the needy for his own satisfaction & that is the reason for the quality of his services. He always focuses on spreading positive energy. As an NRI, he has been serving many Indians & Americans in various forms through numerous organizations and as an individual for the past 6 years. He has been providing free physical therapy treatments, free blood tests & yoga every day in India by setting up 3-week mobile health camps in slums, schools and senior homes. These services are offered under the NRI SEVA Foundation with his personal financial backing . He’s been playing an important role in FIA Chicago (Federation of Indian Associations) and representing pride in India to all communities in Chicago. The Indian Consulate in Chicago recognized his dedication and took his help to Coordinate KALA UTSAV in 2014 & confirmed him as Coordinator for 2016. Currently he is serving as President of the NRI SEVA Foundation & Indian American Business Council, Managing Director of the Desiworld TV Channel, Secretary of the Association of Indians in America (AIA), Advisory Board Member of the Indian Diaspora Club, and Indian Government Affairs Chair in TANA. He shares motivating messages from his social media pages followed by more than one million followers.",
                Image = "Harish-Kolasani.png",
                Image2 = "Harish-Kolasani2.png",
                IsStaff = false,
                IsActive = true,
                Facebook = "https://www.facebook.com/HarishKolasani",
                Email = "kolasani@me.com",
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
                Image2 = "Shweta-Singh2.png",
                IsStaff = false,
                IsActive = false,
                Facebook = @"https://www.facebook.com/1ShwetaSingh",
                Email = @"Ssingh9@luc.edu",
                LinkedIn = @"https://www.linkedin.com/in/shweta-singh-a7004714"
            });

            //Sagar Kumar
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Sagar",
                LastName = "Kumar",
                Position = "Treasurer",
                Bio = "Sagar Kumar is an Industrial Engineer by profession from Purdue University and received his MBA with emphasis on Entrepreneurship and Leadership from Arizona State University. He worked in Honeywell Aerospace as a New Product Development Program Manager for Honeywell’s top commercial jet engine. He worked for Honeywell for 7 years before moving back to Illinois. Sagar became an active board member in late 2016. He brings a very strategic and project-based mindset to MAFS as well a more technical approach on the day to day operations.",
                Image = "Sagar-Kumar.png",
                Image2 = "Sagar-Kumar2.png",
                IsStaff = false,
                IsActive = true,
                Facebook = @"https://www.facebook.com/sagar.kumar.purdue",
                Email = @"sagark@umasinc.com",
                LinkedIn = @"https://www.linkedin.com/in/sagar-kumar-93991632/"
            });

            //James D'Mello
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "James",
                LastName = "DMello",
                Position = "Board Member",
                Bio = "Mr. D’mello has a Master’s degree in education from Mumbai, India. He started his career as a math teacher for 13 years in India as well as 4 years in Chicago at Nettle Horst School. He worked for whole foods market as a customer service manager for 14 years. Currently, he is with MB Financial Bank. He was born and raised in Gujarat, India. He was the State and National champion in Soccer and Field Hockey. James found that MAFS is one of the largest institutions that provide all kinds of service to all different religions in Good Faith and that is what made him come and join the board to give some extra time in helping fund programs and different events. He has worked in all different fields and lived everywhere east to west but found that MAFS is one of the best in the Chicagoland area. He wants to help our community with all respects to all religions and stay united as an Indian.",
                Image = "James-DMello.png",
                Image2 = "James-DMello2.png",
                IsStaff = false,
                IsActive = true,
                Facebook = string.Empty,
                Email = @"JDMello@mbfinancial.com",
                LinkedIn = string.Empty
            });

            //Sonal Patel
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Sonal",
                LastName = "Patel",
                Position = "Board Member",
                Bio = "Dr. Patel is a doctor of anesthesiology and has a fellowship in pain management. She graduated with honors in 1994. She has more than 23 years of experiences in the medical field. She works at St Alexius Medical Center in Hoffman Estates where she is also the clinical director of pain management. She strongly believes in giving back to society and preserving our heritage and culture. Along with supporting MAFS, she also supports VGS and AIA organizations. She joined the board in 2017.",
                Image = "Sonal-Patel.png",
                Image2 = "Sonal-Patel2.png",
                IsStaff = false,
                IsActive = true,
                Facebook = @"https://www.facebook.com/sonal.n.patel",
                Email = @"sonalnpatel@hotmail.com",
                LinkedIn = string.Empty
            });

            //Staff
            //Santosh Kumar
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Santosh",
                LastName = "Kumar",
                Position = "Executive Director",
                Bio = "TODO",
                Image = "Santosh-Kumar.png",
                Image2 = "Santosh-Kumar.png",
                IsStaff = true,
                IsActive = true,
                Facebook = @"https://facebook.com/santoshk1250",
                Email = @"santoshk@umasinc.com",
                LinkedIn = @"https://www.linkedin.com/in/metropolitan-asian-family-services-729b8056"
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
                FlickrGallery = "",
                YouTubeLink = "https://www.youtube.com/embed/Myuwkm0VFPk"
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
                FlickrGallery = "",
                YouTubeLink = "https://www.youtube.com/embed/iT7NgXmzU_c"
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
                FlickrGallery = "",
                YouTubeLink = String.Empty
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
                FlickrGallery = "",
                IssuuLink = String.Empty,
                YouTubeLink = String.Empty
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
                FlickrGallery = "",
                IssuuLink = String.Empty,
                YouTubeLink = String.Empty

            });
            
            //2016 Fundraiser
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2016, 10, 22),
                IsMini = false,
                Location = "Downers Grove, IL",
                Venue = "Ashyana Banquets",
                Intro = "The 24th Annual Fundraiser of Metropolitan Asian Family Services (MAFS) was a grand success with around 1000 people attending the program.",
                WriteUp = "The evening showcased multi-cultural Colombian & Polish dances by Tierra Colombiana, Polish Ensembles and Indian semi-classical by Madhura Sane of Nritya Natya Kala Academy. The live orchestra set the evening with old Mukesh Melodies by Sanket Patel Group. The event was well-attended by dignitaries from the state and community leaders and headed by Mrs. Santosh Kumar, Executive Director Metropolitan Asian Family Services (MAFS). This year’s MAFS fundraiser was organized as a tribute to Late Mr. Pramod Kumar, Treasurer, and supporter of MAFS. The objective of raising funds was to fill in the gaps from state funding to continue to provide services our seniors. The keynote speaker, Jean Bohnhoff, Director-Illinois Department on Aging shared the state’s vision and goals for senior care for the next fiscal year. She also paid tribute to Mr. Kumar appreciating his professionalism and hard work that contributed to the expansion of Universal Industries, Universal Metro Asian Services, and MAFS. A brief report was presented on MAFS programs by Connie Dogaru, Public Benefits Specialist-MAFS and Awilda Gonzalez, CCP Program Manager-UMAS. Mrs. Santosh Kumar, Executive Director-MAFS while remembering her late husband Mr. Pramod Kumar said, “He was a kind man who touched many lives, and his loss can never be filled.” Her sons Prashant & Sagar Kumar have joined the family business, and they will be a pillar of support for her. The evening commenced with traditional deep lighting and prayers by Swami Mukudananda Ji of Bharat Sevashram, along with the board of directors and community leaders. Dr. Jafri, President MAFS, welcomed everyone and gave a heartfelt tribute to Mr. Kumar. Many other dignitaries and community leaders shared their sentiments and paid tribute to Mr. Kumar. The Master of Ceremonies were Jyotsna Vasudeva, Marketing Director-UMAS and Alka Sharma, Channel Head & RJ. They both hosted the event beautifully - introducing the speakers & dignitaries, creating excitement over donation checks, raffles, auction tickets, and kept the show moving smoothly at a steady pace while keeping the audience enthralled. Among the attending dignitaries were Mayor of Oak Brook, Gopal Lalmalani; State representative from Aurora, Stephanie Kifowit; Candidate for Congressman from 8th District, Raja Krishnamoorthi; Cook County Commissioner, Edward Moody (represented by his brother Fred Moody); Director-Department on Aging, Jean Bohnhoff; CLESE Executive Director, Marta Pereyra; Trustee-Township of Schaumburg, Nimish Jani; Chairman for the Naperville Indian-American Outreach, Krishna Bansal; Candidate-Dupage Recorder of Deeds, Moon Khan; Chairman AMUAA, Ateeq Ahmed; Board Member AMUAA, Atia Ushman; Dr. Aasifa Kansari; Midwest Manager for Air India-Nakul Singh Chand; Owner-Patel Brothers, Mafatlal Patel, and the MAFS Board of Directors. Air India sponsored two economy class tickets to be auctioned at the event in support of MAFS fundraiser. MAFS also received support from its other major sponsors - Wintrust Bank, Medstar Laboratory, Mode Architects, Steeplechase, Healthcare Solutions, Dupage Dental Clinic.",
                CoverPhoto = "Fundraiser/2016.jpg",
                FlickrGallery = "",
                IssuuLink = "9480861/43271631",
                YouTubeLink = String.Empty
            });

            //2015 Fundraiser
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2015, 10, 10),
                IsMini = false,
                Location = "Downers Grove, IL",
                Venue = "Ashyana Banquets",
                Intro = "An unbelievable amalgamation of immigrant and mainstream community members, about a 1,000 people in the audience gathered to celebrate elderly senior services for  the 23rd  annual fundraising dinner of Metropolitan Asian Family Services on Saturday, October 10, 2015 at Ashyana Banquet Hall India, 1620  75th St., Downer’s Grove, IL 60516.",
                WriteUp = "The event began with the lightning of a traditional lamp by Pandit Jagdishbhai Joshi followed by Ganesh Vandna by the members. Prominent dignitaries in attendance were Mr. Ausaf Sayeed, the Counsel General, India, Mr. Nirav Shah, the Director, Illinois department of Public Health, Michelle Mussaman, State of Representative, Mr. Gopal Lalamalani, the Village President, Oakbrook, Mr. Krishna Bansal, an Outreach Specialist, Naperville, Ms. Marta Pereyra, the Executive director, CLESE who spoke of great appreciation to the splendid home care and adult day care services rendered for immigrant the elderly seniors of Asian Communities at large as well the East European Communities in the Metropolitan Chicago  under the dynamic leadership of Mr. and Mrs. Kumar. Mariachi Universal of Chicago, Illinois took part in making  the evening of our fundraiser one to remember with their Mexican Folkloric Music, their heavily voices and their attire. Polonia group captivated the audience with their delightfully graceful Polish Folk Dance in their traditional attire making the annual dinner a fascinating evening. Kathrine Jafri and group with their enchantingly charming Bollywood Dance Act, delighting the seniors and others making a memorable entertainment experience. Arya Dance Academy performed dances choreographed by Shree Desai. Raju Bhankapur & Pratibha Jairath performed Bollywood Music.",
                CoverPhoto = "Fundraiser/2015.jpg",
                FlickrGallery = "",
                IssuuLink = "9480861/33913829",
                YouTubeLink = "https://www.youtube.com/embed/sBxEkwXEQqM"
            });

            //2016 Mini TODO
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2016, 5, 21),
                IsMini = true,
                Location = "Naperville, IL",
                Venue = "MAFS Naperville",
                Intro = "Over 300 seniors and prominent community members attended Metropolitan Asian Family Service’s Mini Fundraising dinner on May 21, 2016 at 1032 E Ogden Ave, Naperville, IL. ",
                WriteUp = "The celebration started with the Diya ceremony which was performed by Swami Mukundananda of Bharat Sevashram of Chicago. Prominent leaders in attendance were Steve Chirico Mayor of Naperville, Aurora Alderman Rick Mervine, Krishna Bansal, Outreach Coordinator Naperville Village, and MAFS board members. In his opening remarks our keynote speaker, Steve Chirico, Mayor of Naperville, spoke about the importance such community services provide to the society and commended the MAFS team for serving the community on all fronts for over 3 decades. Mr. Krishna Bansal in his opening statement said that he counts himself as part of MAFS family and urged the community to come forward and join in MAFS mission of serving and caring. Mr. Rick Mervine was honored to be a part of this event and wanted to know if it was possible to have a center like this in his constituency of Aurora. Ms. Awilda Gonzalez UMAS CCP Director spoke about her concerns on the recent budget cut and the effect it is having on our programs.Ms. Gonzalez spoke about all our lobbying efforts to save Community Care and Adult Day Care Services. The entertainment program began with the Naperville ADS seniors performing a beautiful Bollywood song \"Prem Ratan Dhan Payo\" wonderfully choreographed by ADS coordinators Heena Mehta and Eva Contractor. Our Schaumburg ADS seniors performed a pulsating Gujarati garba \"Nagada Sang Dhol Baje\" ably choreographed by ADS coordinators Dipti Shah and Mital Patel. Chicago and Orland Park ADS seniors preformed 2 more mesmerizing Garbas choreographed by ADS coordinators Pankaj Patel and Grishma Shah respectively but the stage was set on fire by the students of Glenbard North High School, Carol Stream performing a Punjabi Bhangra. The Niles ADS seniors stole the show with 80 year olds performing \"Ladki Kar Gayi Chull\" with their walking sticks as props. Chicago Staff Pankaj and Kiran Patel brought a tear to every eye by their heartwarming performance and Naperville Staff also showcased their talent by performing taditional garba. The grand finale was by the Naperville ADS seniors performing a lively Qawwali number which was encored by the audience. Our emcees Neelam Desai, Naperville Manager, Jahnavi Bavisi, Niles Manager and Nehal Thakkar, Carol Stream  CCP Supervisor successfully managed the entire program and the event was concluded with vegetarian dinner prepared by our Kitchen staff. Mrs. Santosh Kumar presented the vote of thanks.",
                CoverPhoto = "Fundraiser/2016-mini.jpg",
                FlickrGallery = "",
                IssuuLink = String.Empty,
                YouTubeLink = String.Empty
            });

            //2017 Mini
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2017, 5, 20),
                IsMini = true,
                Location = "Schaumburg, IL",
                Venue = "MAFS Schaumburg",
                Intro = "Over 300 seniors and prominent community members attended Metropolitan Asian Family Service’s Mini Fundraising dinner on May 20, 2017 at 1421 S. Roselle Road Schaumburg, IL 60193.",
                WriteUp = "The celebration started with the Ribbon Cutting Ceremony of the Schaumburg Adult Day Care location by Congressman Raja Krishnamoorthi & State Rep. Ms. Mussman . This was followed by Lighting of the auspicious Deep by prominent leaders of the community like Congressman Raja Krishnamoorthi, Vipan Wadhera President of Hari Om Mandir, Krishna Bansal Outreach Coordinator Naperville Village, James D’Mello, MB Financial, Syed Mohammed, Manager, US Bank, Cameel Mohammed, Private Banker, Chase Bank, Dr. Firdaus Jafri, President, MAFS, Neil Patel, Owner, MedStar and Mrs. Santosh Kumar, Executive Director, MAFS. CHIEF GUEST & OPENING REMARKS In his opening remarks, Chief Guest, Congressman Raja Krishnamoorthi, spoke about the importance of such community services provided to seniors which also help their children to continue to work without stress and worry. He commended the MAFS team for serving the community on all fronts for over 3 decades. Keynote Speaker State Rep. Michelle Mussman, recognized the efforts of Executive Director, Mrs. Santosh Kumar, has made to help the community and provide services to as many people as possible in Chicagoland area. Mr. Krishna Bansal in his opening statement said that he counts himself as part of the MAFS family and urged the community to come forward and join in the MAFS mission of serving and caring. Mr. O.P. Meena, Indian Consul, Chicago, appreciated the services provided by MAFS and spoke very highly about MAFS’s efforts to make Yoga Day a big success and invited the whole community to join in the upcoming Yoga day being held in Naperville, IL on June 24, 2017. Guest speaker, Executive Director of CLESE, Marta Pereyra, spoke about the years she has been associated with MAFS and congratulated MAFS for its extra ordinary efforts to serve the community in spite of budget cut for social services. Mrs. Kumar, Executive Director, stated that due to the recent budget impasse MAFS is at the threshold of its limits and community members should understand these facts and come forward to support these programs if we are to continue to serve our seniors now and in the future. She then thanked all the seniors for pumping and shouting their hearts out and appreciated MB Financial Bank for donating $1000 for the cause. ENTERTAINMENT The entertainment program began with Ganesh Pushpanjali by Kalapadma Dance Academy choreographed by Ruth Varghese and performed by Anjali Varghese, Jenish Bulsara, Eshana Patel, Shreya Rawal, Maya Patel and Krishna Shah. The Seniors’ performances began with a rocking show by Niles ADS seniors performing on “Woh Ladki Hai Kaha”. Schaumburg ADS seniors followed by showcasing “Zindagi Zinda Dili Ka Naam Hai” ably introduced with a speech from ADS senior Jayesh Desai. Not to be left behind Naperville ADS senior Tabassum Rabbini received a standing ovation after performing on “Inhi Logo Nein” from the movie “Pakeezah”. Naperville ADS seniors gave another Dhamakedar dance performance with “Bollywood Ka Safar”, a medley of songs from the black and white era of 1960 to the colored times of today. The performances were ably ended by Chicago ADS seniors showing their various talents (Hoonar) and demonstrating “Unity in Diversity” by their costumes from different states of India. DINNER & PRESENTERS The audience enjoyed a delicious vegetarian dinner catered from Shree Restaurant, Westmont IL. Dinner was followed by a melodious performance of Bollywood songs by local singers Chetan Trivedi and Dr. Sonal Patel ably supported by professional DJ Abhi Trivedi.Our emcees Neelam Desai, Naperville Manager and Jahnavi Bavisi, Niles Manager successfully managed the entire program and the event was concluded with the vote of thanks presented by Mrs. Santosh Kumar.",
                CoverPhoto = "Fundraiser/2017-mini.png",
                FlickrGallery = "",
                IssuuLink = "9480861/55871635",
                YouTubeLink = "https://www.youtube.com/embed/dQCpjxddMUk"
            });

            //2017 Main
            context.Fundraisers.AddOrUpdate(r => r.Date, new Fundraiser
            {
                Date = new DateTime(2017, 11, 18),
                IsMini = false,
                Location = "Downers Grove, IL",
                Venue = "Ashyana Banquets",
                Intro = "MAFS Celebrate 25th Anniversary – A Pioneer, Change the landscape of Social Services in Chicagoland-Looking Back, Moving Forward… MAFS converts Ashyana Banquet Hall into Theater to showcase special Dance Drama, Kal Bhi, Aaj Bhi, written, produced & Directed by Kushal Bose.",
                WriteUp = "Commemorating its Silver Jubilee, Metropolitan Asian Family Services held its 25th annual fundraising dinner on November 18, 2017, at Ashyana Banquets, Downers Grove IL. The celebration started with the traditional “Deep-Lighting” performed by Swami Mukundananda of Bharat Sevashram Sangha, Aurora IL. Prominent dignitaries in attendance were Cook County Board President Toni Preckwinkle, Congressman Raja Krishnamoorthi, Schaumburg Trustee Nimish Jani, Philanthropist Deepak Kant Vyas, Dr. Vijay Prabhakar, Executive Director CLESE Marta Pereyra, Chairman for Indian Community Outreach Krishna Bansal, FIA Ex-President Sunil Shah, Chand Kumawat, Chairman of Manees Media, India, Anis Ahmed, Chairman, AMU of Greater Chicago, MAFS Board Members, and other community leaders Narsinhbhai Patel, Dr Rasik Shah and business supporters including seniors and their families. Congressman Raja Krishnamoorthi commended the MAFS team for its exemplary service to the community for 25 long years and said he wishes MAFS will continue to do so for many more years in future. Honorable Consul General of India Ms. Neeta Bhushan also congratulated MAFS for completing 25 years of serving the elderly and other immigrant populations in Chicagoland. She praised the array of services MAFS provides to the community successfully, Cook County Board President Toni Preckwinkle appreciated the dedication MAFS has to serve the community and gave good wishes to continue for many more years. A warm welcome was given to Mr. Sagar Kumar MAFS Treasurer, who spoke about the limited amount of funds MAFS receives and the expenses and deficits the company faces every year. Mrs. Santosh Kumar Executive Director MAFS, spoke about the long journey and the trials and tribulations they faced to come this far. She also remembered all the people past and present leaders of the community, such as Shankerprasad Bhatt, Manohar Manchanda, Ramesh Goyal, Narendra Patel, Yasmin Tiwana, Dr. Firdaus Jafri, Rosemary Gemperly, Marta Pareyra, who have helped to accomplish MAFS's mission to educate, counsel, assist and empower immigrants to become productive member of American Society. She and her Late husband Mr. Kumar worked very hard to bring MAFS, a pioneer organization, who has changed the landscape of social services in Chicagoland area that far. She requested the community, that MAFS was created for them and want them to take care of the MAFS, a well-recognized, trusted and licensed by County, State, and Federal Government. She also assures the community about MAFS’s future and presented her both the sons, as future leaders. I believe that MAFS will grow more in the coming years, to lead the way, we already have our future leaders- energetic, technically savvy and competent in management skills, She said. Under this new leadership, MAFS is now better positioned to find new resources to find the solutions to ever growing problems and appeals the community to support its mission wholeheartedly. She also thanked its sponsors, Dr. Jafri, Board president, board members, MAFS/UMAS staff Mr. Jain. Kushal Bose, Madhura Sane and other artist seniors, friends and families for their support and taking time to attend and making it an unforgettable gala celebration. A warm welcome was given to Sagar Kumar, MAFS treasurer, who gave the financial report of MAFS and encouraged the community to read pages 16-18 of Souvenir book and understand its funding structure and spoke about the difference in fund receivables and expenses. He explains why MAFS has to raise funds to fill the gaps in funding and to match the grants to accomplish its mission to help the community. An award ceremony was performed by MAFS board and dignitaries, Hon’ble Nita Bhushan, Indian Consul General, Ms. Tony Preckwinkle, Chicago Board president, Dr. Vijay Prabhaker, Ethnic Taskforce, Chand Kumawat, Chairman, Manees Media The Pramod Kumar Philanthropy Award was presented to Mr. Deepak Kant Vyas Chairman & CEO Redberri Corp, The Partnership Award was presented to Mr. Sean Dunn, VP WINTRUST Community Bank, Pillar of MAFS Award was given to Ms. Promila Mehta Manager Social work Chicago center; Lifetime Achievement Award was given to Mr. Prem Jalota Manager Roselle center, Employee of the Year Award was given to Ms. Connie Dogaru SOS Coordinator, Volunteer of the Year Award was given to Ms. Bhanumati Maheta, a Yoga Teacher. A special Award of GSA Outstanding Citizen of the year 2017 given by Shri Pranav Mukherjee, President of India on July 1, 2017, was also presented by Hon’ble Nita Bhushan, Indian Consul General, and Dr. Vijay Prabhaker to Mrs. Santosh Kumar, Founder of Metropolitan Asian Family Services, IL USA. SENATE RECOGNITION – was given by Senator Cristina Castro and presented by Ms. Nazneen to Mrs. Santosh Kumar, Founder of MAFS which reads: The Illinois Senate of 100th General Assembly of the State of Illinois acknowledges- METROPOLITAN ASIAN FAMILY SERVICES, In recognition of celebrating 25 years as a multi-cultural and multi-ethnic organization committed to educate, assist and empower the immigrant community to adjust to life in United States, and extends its congratulations and best wishes on this momentous occasion and further commends MAFS for its continued commitment to providing comprehensive and integrated social services to our immigrant population. The entertainment began with Ganesh Vandana by Soorya Dance School of Northbrook, ably followed by a traditional Bosnian Dance by the Bosnia and Herzegovina Club of Chicago but Reena's Rockers from Naperville really rocked the hall with their fusion dance mix of Ballet and Bharatnatyam. A special dance-drama was showcased to celebrate 25 years of Metropolitan Asian Family Services - \"Kal Bhi Aaj Bhi\" conceived, written, produced and directed by Mr. Kushal Bose was a multimedia play that incorporates live dance, narration, video projection and music that essentially translates to “Yesterday, Today and Tomorrow”. The play chronicles the evolution of Indian classical music, dance and musical instruments over five thousand years that have historically adopted and evolved with many styles- influenced by both from within and outside India. The dances were mesmerizingly performed by the well known Kathak actor/dancer from Chicago’s own Madhura Sane. It tells the story of roots of Indian classical music, found in the Vedic literature of Hinduism such as Samaveda and Rigveda. Told through in documentary style of narration and live examples, it presents three art forms- musical instruments (vadya), vocal music (geet) and dance (nritya). The play captured and demonstrated skillfully the essence of the development of Sangeeta as it became a distinct genre of art, expressing emotion, feelings, spirit, and passion of epics like Ramayana, Mahabharata, and other Hindustani literature over thousands of years. The audience was captivated by this interesting tale of their own history, heritage, and culture The evening was brought to a close by \"Jeena Issi Ka Naam Hai\" a musical tribute to the Founder/ CFO of MAFS, Late Mr. Pramod Kumar performed by well-known artists from Chicago again researched, conceived and directed by Mr. Kushal Bose, whose inventive and intelligent plays and musical programs have been enlightening Chicago audience over two decades . He brilliantly traces the life of Mr. Kumar from 1937-2016 era. His life journey was showcased through video and matched the music drama of that era. Again performed by Madhura Sane, was not only electrifying, unforgettable but also a spiritual experience. Emcees Jahnavi Bavisi Niles Manager and Neelam Desai Naperville Manager successfully managed the entire program and were able to generate a good amount of donation through their entertaining and lively appeals. The Vote of Thanks was given by MAFS Board Secretary Dr. Rakesh Asthana.",
                CoverPhoto = "Fundraiser/Flyer-Top.jpg",
                FlickrGallery = "",
                IssuuLink = "9480861/55122357",
                YouTubeLink = "https://www.youtube.com/embed/IlH2Jd61ErA"
            });

            
            //CATEGORY
            //Nutrition
            //Nutrition Program
            //Category Nut = new Category();
            //Nut.Title = "Nutrition";
            //Nut.Description = "To eat is a necessity, but to eat intelligently is an art. Our staff and members strongly believe in this adage. We serve hot, fresh, home-cooked meals that take into account the dietary requirements and traditions of Indians, Pakistanis, and Bangladeshis. We also help educate participants on choosing the right kind of foods that help prevent & manage diseases like diabetes and hypertension which are common in our culture.    The smell of masala in the kitchen does not only entice one’s appetite, it also brings people together.  Sharing a meal with a group can be the cure seniors need against feelings of social isolation.  So come join us for a meal and tell that joke you know!  MAFS is in its 15th year of serving hot lunches to the senior citizen population. These lunches are nutritionally balanced but more importantly they provide an opportunity for seniors to make friends and socialize to break free from isolation. These meals are freshly prepared by trained cooks under strict hygienic conditions. We provided 33,905 hot meals to the community this year from our Chicago, Niles and Roselle facilities. ";
            //Nut.IconUrl = @"~/Images/icons/nutrition_icon.png";
            //Nut.BannerImg = "nutrition3.jpg";
            //context.Categories.AddOrUpdate(r => r.Title, Nut);

            //Nutrition Program
            Program Nutrition = new Program();
            Nutrition.Title = "Nutrition";
            Nutrition.ShortDescription = "To eat is a necessity, but to eat intelligently is an art. Our staff and members strongly believe in this adage. We serve hot, fresh, home-cooked meals that take into account the dietary requirements and traditions of Indians, Pakistanis, and Bangladeshis.";
            Nutrition.Description = " We also help educate participants on choosing the right kind of foods that help prevent & manage diseases like diabetes and hypertension which are common in our culture.    The smell of masala in the kitchen does not only entice one’s appetite, it also brings people together.  Sharing a meal with a group can be the cure seniors need against feelings of social isolation.  So come join us for a meal and tell that joke you know!  MAFS is in its 15th year of serving hot lunches to the senior citizen population. These lunches are nutritionally balanced but more importantly they provide an opportunity for seniors to make friends and socialize to break free from isolation. These meals are freshly prepared by trained cooks under strict hygienic conditions. We provided 33,905 hot meals to the community this year from our Chicago, Niles and Roselle facilities. ";
            Nutrition.BannerImg = "nutrition3.jpg";
            Nutrition.Icon = "nutrition_icon.png";
            
            context.Programs.AddOrUpdate(r => r.Title, Nutrition);

            //Public Benefits
            Program PublicBenefits = new Program();
            PublicBenefits.Title = "Public-Benefits";
            PublicBenefits.ShortDescription = "Have you ever wondered what benefits you qualify for? Many people do not know what is available to them.  MAFS can help you understand and apply for benefits you qualify for.";
            PublicBenefits.Description = "MAFS is a pioneer in providing social services to low-income and underserved populations. The demand for these kinds of services is increasing due to the slow recovery of our economy. MAFS staff assists clients in accessing public benefits available to fit their individual needs. Our staff helps fill-out applications for these services and escorts them to the appropriate public benefit offices such as Department of Human Services or Social Security Administration, Immigration and Naturalization to submit the application and serve as their interpreter. We also translate official forms in Hindi, Urdu, Gujarati, Spanish and Bosnian languages to facilitate the process of applying for benefits. Our staff acts as liaisons between the client and public officials to help our community members get the help and support they require. This year we had the privilege of helping complete 6,225 cases in Cook, Suburban Cook County, DuPage and Lake County.  MAFS can help you understand and apply for benefits like:  + Medicare + Medicaid + Social Security + Access to Care + Citizenship/Immigration + Transportation + Kids Care + SSI Prescription Drug Assistance + Food Stamps  + LIHEAP  + SHIP and many others.  Come in and talk to our friendly staff about your needs and we will try our utmost to help!";
            PublicBenefits.BannerImg = "ceda.jpg";
            PublicBenefits.Icon = "public_benefits_icon.png";
            context.Programs.AddOrUpdate(r => r.Title, PublicBenefits);

            //Education
            Program Education = new Program();
            Education.Title = "Education";
            Education.ShortDescription = "At MAFS we believe in education.";
            Education.Description = "Education and knowledge help you better understand yourself and the world around you. It also helps you obtain a higher paying job. To help educate and train our community we offer educational and technical programs including, English as a Second Language (ESL), Bright Ideas, CPR training, and Computer training";
            Education.BannerImg = "education.jpg";
            Education.Icon = "education_icon.png";
            context.Programs.AddOrUpdate(r => r.Title, Education);

            //Research
            Program Research = new Program();
            Research.Title = "Health-Research";
            Research.ShortDescription = "We partner with the leading health and educational institutions to explore and study problems that concern our culture the most.";
            Research.Description = "We have collaborated with Northwestern University’s Feinberg School of Medicine to teach the South Asian community how to make important dietary changes, engage in an active lifestyle, reduce stress, and lose weight to reduce or prevent their chances of stroke and/or heart attacks We also partner with the Asian Health Coalition on two projects. The first is the Pink Pashmina project which offers free breast cancer screenings and mammograms to South Asian woman. The second is to provide our community with free screening and testing for Hepatitis B.";
            Research.BannerImg = "research.jpg";
            Research.Icon = "health_icon.png";
            context.Programs.AddOrUpdate(r => r.Title, Research);

            ////Citizenship
            //Program Citizenship = new Program();
            //Citizenship.Title = "Citizenship-and-Immigration-Assistance";
            //Citizenship.ShortDescription = "Since its establishment, MAFS has, and continues to provide help with the immigration and naturalization process for community members.";
            ////more
            //Citizenship.Description = "MAFS also helps applicable members of the community in acquiring their Overseas Citizen of India (OCI) card. This year we have helped 160 seniors to fill N.400 for citizenship and I-130 for family petition. This service is provided without outside funding, however, we continue this service to benefit immigrant families. ";
            //Citizenship.BannerImg = "immigration.jpg";
            //context.Programs.AddOrUpdate(r => r.Title, Citizenship);

            ////HealthInsurance
            //Program HealthInsurance = new Program();
            //HealthInsurance.Title = "Health-Insurance-Assistance";
            ////Not the greatest
            //HealthInsurance.ShortDescription = " We collaborate with the Asian Health Coalition to assist our community with the Affordable Care Act (Obamacare).";
            ////Not the greatest
            //HealthInsurance.Description = "Metropolitan Asian Family Services has collaborated with the Asian Health Coalition for assisting our community with the Affordable Care Act also known as Obamacare. It was the state-run outreach and education program offered to all legal residents of Illinois to enroll into Medicaid or Marketplace health insurance. This year our Navigators, Ms. Nazneen Begum and Meenu Jethi, have enrolled over 500 individuals into Medicaid or Marketplace health insurance and reached out to over 1500 people through outreach at temples, mosques, churches and Gurudwaras.";
            //HealthInsurance.BannerImg = "obamacare.jpg";
            //context.Programs.AddOrUpdate(r => r.Title, HealthInsurance);

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
          //Seed Membership
           
        }

        private void SeedMembership()
        {
            if(!WebSecurity.Initialized){
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            }
            
            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if(!roles.RoleExists("SuperAdmin")){
                roles.CreateRole("SuperAdmin");
            }
            if (membership.GetUser("prashantk@umasinc.com", false) == null)
            {
                membership.CreateUserAndAccount("prashantk@umasinc.com", "Umasinc@1");
            }
            if(!roles.GetRolesForUser("prashantk@umasinc.com").Contains("SuperAdmin")){
                roles.AddUsersToRoles(new[] { "prashantk@umasinc.com" }, new[] { "SuperAdmin" });
            }
        }
    }

 } 

   

