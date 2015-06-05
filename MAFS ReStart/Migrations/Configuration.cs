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
            });
            //Rakesh Asthana
            context.Members.AddOrUpdate(r => r.FirstName, new Member
            {
                FirstName = "Rakesh",
                LastName = "Asthana",
                Position = "Board Member",
                Bio = "is a veterinarian by education and is a retired Major of the Indian army. After having practiced for nearly eighteen years as a veterinarian with the Indian Army, he was seconded to the Kuwaiti Army for two years. After having migrated to the US in 1993, Dr. Asthana has worked as a Cardiovascular Specialist, with various pharmaceutical companies like Parke-Davis, Pfizer, Glaxo, Novartis, and Astra Zeneca. He currently works as a \"Senior Cardiovascular Specialist\" with the Japanese Pharmaceutical company Daiichi-Sankyo US.  He tirelessly volunteers in various not-for-profit organizations. He sits on the Board of Directors of Black Feet Volunteer Medical Corps (BVMC). Rakesh also volunteers his time with \"Young Hearts 4 Life\", a stellar organization, screening young high school children in the US to avoid \"Sudden Cardiac Death\" syndrome. Rakesh firmly believes that the elderly and senior citizens in the US need our help and that MAFS is doing commendable work, which should be whole-heartedly supported.",
                Image = "Rakesh-Asthana.png",
                Image2 = "Rakesh-Asthana2.png",
                IsStaff = false,
            }); 
             
            //Seed Fundraiser
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
                CoverPhoto = "fundraiser.jpg",
                IssuuLink = "9480861/11710604",
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
                CoverPhoto = "2012.jpg",
                IssuuLink = "9480861/6999087",
                FlickrGallery = ""
            }); 



        }
    }
}
