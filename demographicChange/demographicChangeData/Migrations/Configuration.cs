namespace DemographicChangeData.Migrations
{
    using demographicChangeEntity.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DemographicChangeData.Context.DemographicChangeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DemographicChangeData.Context.DemographicChangeContext";
        }

        protected override void Seed(DemographicChangeData.Context.DemographicChangeContext context)
        {
            context.ChangeByEthnicGroupsContext.AddOrUpdate(x => x.Id,
                new DemographicChangeByEthnicGroupsEntity()  {Id = 1, Year = 1989, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 2, Year = 1989, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 3, Year = 1989, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 4, Year = 1990, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 5, Year = 1990, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 6, Year = 1990, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 7, Year = 1991, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 8, Year = 1991, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 9, Year = 1991, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 10, Year = 1992, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 11, Year = 1992, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 12, Year = 1992, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 13, Year = 1993, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 14, Year = 1993, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 15, Year = 1993, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 16, Year = 1994, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 17, Year = 1994, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 18, Year = 1994, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 19, Year = 1995, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 20, Year = 1995, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 21, Year = 1995, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 22, Year = 1996, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 23, Year = 1996, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 24, Year = 1996, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 25, Year = 1997, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 26, Year = 1997, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 27, Year = 1997, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 28, Year = 1998, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 29, Year = 1998, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 30, Year = 1998, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 31, Year = 1999, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 32, Year = 1999, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 33, Year = 1999, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 34, Year = 2000, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 35, Year = 2000, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 36, Year = 2000, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 37, Year = 2001, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 38, Year = 2001, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 39, Year = 2001, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 40, Year = 2002, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 41, Year = 2002, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 42, Year = 2002, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 43, Year = 2003, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 44, Year = 2003, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 45, Year = 2003, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 46, Year = 2004, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 47, Year = 2004, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 48, Year = 2004, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 49, Year = 2005, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 50, Year = 2005, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 51, Year = 2005, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 52, Year = 2006, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 53, Year = 2006, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 54, Year = 2006, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 55, Year = 2007, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 56, Year = 2007, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 57, Year = 2007, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 58, Year = 2008, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 59, Year = 2008, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 60, Year = 2008, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 61, Year = 2009, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 62, Year = 2009, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 63, Year = 2009, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 64, Year = 2010, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 65, Year = 2010, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 66, Year = 2010, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 67, Year = 2011, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 68, Year = 2011, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 69, Year = 2011, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 70, Year = 2012, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 71, Year = 2012, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 72, Year = 2012, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 73, Year = 2013, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 74, Year = 2013, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 75, Year = 2013, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 76, Year = 2014, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 77, Year = 2014, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 78, Year = 2014, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 79, Year = 2015, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 80, Year = 2015, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 81, Year = 2015, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 82, Year = 2016, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 83, Year = 2016, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 84, Year = 2016, Ethnicity = "Roma", PopulationCount = 5161458 },

                new DemographicChangeByEthnicGroupsEntity() { Id = 85, Year = 2017, Ethnicity = "Hungarian", PopulationCount = 15000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 86, Year = 2017, Ethnicity = "Romanian", PopulationCount = 3000000 },
                new DemographicChangeByEthnicGroupsEntity() { Id = 87, Year = 2017, Ethnicity = "Roma", PopulationCount = 5161458 }
            );
        }
    }
}
