using GetRate.Model.Data;
using GetRate.Model;
using System.Linq;
using System.Data.Entity.Infrastructure.Design;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace GetRate.Model
{
    public static class DataWorker
    {
        #region COUNTRIES
        //Get all countries
        public static List<Country> GetAllCountries()
        {
            using (var db = new GetRateContext()) 
            {
                var countries = db.Countries;
                var query = db.Countries.AsQueryable().OrderBy(c => c.NameENG);

                return query.ToList();
            }
        }

        //create Country
        public static string CreateCountry(string countryNameENG, string countryNameUKR)
        {
            string result = "Country is exists already!";

            using (var db = new GetRateContext())
            {
                var countries = db.Countries;

                bool checkIsExist = countries.Any(co => co.NameENG == countryNameENG);

                if (!checkIsExist)
                {
                    Country newCountry = new Country();
                    newCountry.NameENG = countryNameENG;
                    newCountry.NameUKR = countryNameUKR;

                    countries.Add(newCountry);
                    db.SaveChanges();
                    result = "Country added successfully!";
                }

                return result;
            }
        }

        //edit Country
        public static string EditCountry(Country oldCoountry, string newNameENG, string newNameUKR)
        {
            string result = "There is no such country!";

            using (var db = new GetRateContext())
            {
                Country country = db.Countries.FirstOrDefault(c => c.Id == oldCoountry.Id);

                if (country != null)
                {
                    country.NameENG = newNameENG;
                    country.NameUKR = newNameUKR;

                    db.SaveChanges();
                    result = "Country is changed!";
                }
            }
            return result;
        }

        //delete Country
        public static string DeleteCountry(Country country)
        {
            string result = "There is no such country!";

            using (var db = new GetRateContext())
            {
                var countries = db.Countries;

                var deletedCountry = (from c in countries
                                      where c.Id == country.Id
                                      select c).FirstOrDefault();

                if (deletedCountry != null)
                {
                    db.Countries.Remove(deletedCountry);
                    db.SaveChanges();
                    result = $"Country {deletedCountry.NameENG} deleted!";
                }
            }
            return result;
        }

        //get Country by Id
        public static Country GetCountryById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.Countries.FirstOrDefault(c => c.Id == id);
            }
        }

        #endregion

        #region CITIES
        //Get all cities
        public static List<City> GetAllCities()
        {
            using (var db = new GetRateContext())
            {
                var query = db.Cities.AsQueryable().OrderBy(c => c.NameENG);

                return query.ToList();
            }
        }

        //create City
        public static string CreateCity(string cityNameENG, string cityNameUKR, Country country)
        {
            string result = "City is exists already!";

            using (var db = new GetRateContext())
            {
                var cities = db.Cities;

                bool checkIsExist = cities.Any(co => co.NameENG == cityNameENG);

                if (!checkIsExist)
                {
                    City newCity = new City();
                    newCity.NameENG = cityNameENG;
                    newCity.NameUKR = cityNameUKR;
                    newCity.CountryId = country.Id;

                    cities.Add(newCity);
                    db.SaveChanges();
                    result = "City added successfully!";
                }
            }
            return result;
        }

        //edit City
        public static string EditCity(City oldCity, string newNameENG, string newNameUKR, Country newCountry)
        {

            string result = "There is no such city!";

            using (var db = new GetRateContext())
            {
                City city = db.Cities.FirstOrDefault(co => co.Id == oldCity.Id);

                if (city != null)
                {
                    city.NameENG = newNameENG;
                    city.NameUKR = newNameUKR;
                    city.CountryId = newCountry.Id;

                    db.SaveChanges();
                    result = "City is changed!";
                }
            }
            return result;
        }
        //delete City
        public static string DeleteCity(City city)
        {
            string result = "There is no such city!";

            using (var db = new GetRateContext())
            {
                var cities = db.Cities;

                var deletedCity = (from c in cities
                                   where c.Id == city.Id
                                   select c).FirstOrDefault();

                if (deletedCity != null)
                {
                    db.Cities.Remove(deletedCity);
                    db.SaveChanges();
                    result = $"City {deletedCity.NameENG} deleted!";
                }
            }
            return result;
        }

        public static City GetCityById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.Cities.FirstOrDefault(c => c.Id == id);
            }
        }
        #endregion

        #region ADDRESSES
        //Get all addresses
        public static List<Address> GetAlAddresses()
        {
            using (var db = new GetRateContext())
            {
                var query = db.Addresss.AsQueryable().OrderBy(a => a.StreetBuildingENG);
                return query.ToList();
            }
        }

        //create Address
        public static string CreateAddress(string NameENG, string NameUKR, City city)
        {
            string result = "Address is exists already!";

            using (var db = new GetRateContext())
            {
                var addresses = db.Addresss;

                bool checkIsExist = addresses.Any(co => co.StreetBuildingENG == NameENG);

                if (!checkIsExist)
                {
                    Address newAddress = new Address();
                    newAddress.StreetBuildingENG = NameENG;
                    newAddress.StreetBuildingUKR = NameUKR;
                    newAddress.CityId = city.Id;

                    addresses.Add(newAddress);
                    db.SaveChanges();
                    result = "Address added successfully!";
                }
            }
            return result;
        }

        //edit Address
        public static string EditAddress(Address oldAddress, string newStreetENG, string newStreetUKR, City newCity)
        {
            string result = "There is no such address!";

            using (var db = new GetRateContext())
            {
                Address address = db.Addresss.FirstOrDefault(a => a.Id == oldAddress.Id);

                if (address != null)
                {
                    address.StreetBuildingENG = newStreetENG;
                    address.StreetBuildingUKR = newStreetUKR;
                    address.CityId = newCity.Id;

                    db.SaveChanges();
                    result = "Address was changed successfully";
                }
            }
            return result;
        }

        //delete Address
        public static string DeleteAddress(Address address)
        {
            string result = "There is no such address!";

            using (var db = new GetRateContext())
            {
                var addresses = db.Addresss;

                var deletedAddress = (from a in addresses
                                      where a.Id == address.Id
                                      select a).FirstOrDefault();

                if (deletedAddress != null)
                {
                    db.Addresss.Remove(deletedAddress);
                    db.SaveChanges();
                    result = $"Address {deletedAddress.StreetBuildingENG} deleted!";
                }

            }
            return result;
        }

        public static Address GetAddressById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.Addresss.FirstOrDefault(a => a.Id == id);
            }
        }
        #endregion

        #region COMPANIES
        //Get all companies
        public static List<Company> GetAllCompanies()
        {
            using (var db = new GetRateContext())
            {
                var query = db.Companies.AsQueryable().OrderBy(a => a.NameENG);
                return query.ToList();
            }
        }

        public static string CreateCompany(string NameENG, string NameUKR, Address address, CompanyType companyType)
        {
            string result = "Company is already exists!";

            using (var db = new GetRateContext())
            {
                var companies = db.Companies;

                bool isExists = companies.Any(c => c.NameENG == NameENG);

                if (!isExists)
                {
                    Company newCompany = new Company();
                    newCompany.NameENG = NameENG;
                    newCompany.NameUKR = NameUKR;
                    newCompany.AddressId = address.Id;
                    newCompany.companyType = companyType;

                    companies.Add(newCompany);
                    db.SaveChanges();
                    result = $"Company {newCompany.NameENG} is added successfully!";
                }
            }

            return result;
        }

        //edit Company
        public static string EditCompany(Company oldCompany, string newNameENG, string newNameUKR, CompanyType newCompanyType, Address newAddress)
        {
            string result = "There is no such company!";

            using (var db = new GetRateContext())
            {
                Company company = db.Companies.FirstOrDefault(c => c.Id == oldCompany.Id);

                if (company != null)
                {
                    company.NameENG = newNameENG;
                    company.NameUKR = newNameUKR;
                    company.companyType = newCompanyType;
                    company.AddressId = newAddress.Id;

                    db.SaveChanges();
                    result = $"Company {company.NameENG} was changed successfully";
                }
            }
            return result;
        }

        //delete Company
        public static string DeleteCompany(Company company)
        {
            string result = "There is no such company!";

            using (var db = new GetRateContext())
            {
                var companies = db.Companies;

                var deletedCompany = (from c in companies
                                      where c.Id == company.Id
                                      select c).FirstOrDefault();

                if (deletedCompany != null)
                {
                    companies.Remove(deletedCompany);
                    db.SaveChanges();
                    result = $"Company {deletedCompany.NameENG} deleted!";
                }

            }
            return result;
        }

        public static Company GetCompanyById(int id)
        {
            using(var db = new GetRateContext())
            {
                return db.Companies.FirstOrDefault(c => c.Id == id);
            }
        }
        #endregion

        #region ROUTEPOINTS

        public static List<RoutePoint> GetAllRoutePoints()
        {
            using (var db = new GetRateContext())
            {
                var points = db.RoutePoints;
                var companies = db.Companies;

                var query = from point in points
                            join company in companies
                            on point.CompanyId equals company.Id
                            orderby company.NameENG
                            select point;

                return query.ToList();
            }
        }

        public static string CreateRoutePoint(Company company, List<TransportMode> transportModes, ObservableCollection<UnitType> unitTypes)
        {
            string result = "RoutePoint is already exists!";

            using (var db = new GetRateContext()) 
            {
                bool isExists = db.RoutePoints.Any(rp => rp.CompanyId == company.Id);

                if (!isExists)
                {
                    RoutePoint routePoint = new RoutePoint();
                    routePoint.CompanyId = company.Id;
                    //routePoint.TransportModes = transportModes;
                    //routePoint.UnitTypes = unitTypes;

                    db.RoutePoints.Add(routePoint);
                    db.SaveChanges();
                    result = $"RoutePoint is created!";
                }

            }
                
            return result;
        }

        //edit RoutePoint
        public static string EditRoutePoint(RoutePoint oldRoutePoint, Company newCompany, List<TransportMode> newTransportModes, ObservableCollection<UnitType> newUnitTypes)
        {
            string result = "There is no such RoutePoint!";

            using (var db = new GetRateContext())
            {
                RoutePoint routePoint = db.RoutePoints.FirstOrDefault(rp => rp.Id == oldRoutePoint.Id);

                if (routePoint != null)
                {
                    routePoint.CompanyId = newCompany.Id;
                    //routePoint.TransportModes = newTransportModes;
                    //routePoint.UnitTypes = newUnitTypes;

                    db.SaveChanges();
                    result = $"RoutePoint was changed successfully";
                }
            }
            return result;
        }
        //delete RoutePoint
        public static string DeleteRoutePoint(RoutePoint routePoint)
        {
            string result = "There is no such RoutePoint!";

            using (var db = new GetRateContext())
            {
                var points = db.RoutePoints;

                var deletedRoutePoint = (from c in points
                                      where c.Id == routePoint.Id
                                      select c).FirstOrDefault();

                if (deletedRoutePoint != null)
                {
                    points.Remove(deletedRoutePoint);
                    db.SaveChanges();
                    result = $"RoutePoint is deleted!";
                }

            }
            return result;
        }

        public static RoutePoint GetRoutePointById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.RoutePoints.FirstOrDefault(c => c.Id == id);
            }
        }

        //public static bool IsAuto(RoutePoint routePoint)
        //{
        //    //return routePoint.TransportModes.Any(tm => tm.Equals(TransportMode.Auto));
        //}
        ////public static bool IsRail(RoutePoint routePoint)
        //{
        //    return routePoint.TransportModes.Any(tm => tm.Equals(TransportMode.Rail));
        //}
        ////public static bool IsSea(RoutePoint routePoint)
        //{
        //    return routePoint.TransportModes.Any(tm => tm.Equals(TransportMode.Sea));
        //}
        ////public static bool IsAvia(RoutePoint routePoint)
        //{
        //    return routePoint.TransportModes.Any(tm => tm.Equals(TransportMode.Avia));
        //}


        #endregion

        #region CARGOES

        //Get all unitTypes
        public static List<Cargo> GetAllCargoes()
        {
            using (var db = new GetRateContext())
            {
                var query = db.Cargoes.AsQueryable().OrderBy(c => c.NameENG);

                return query.ToList();
            }
        }

        //create Cargo
        public static string CreateCargo(string cargoNameENG, string cargoNameUKR, string cargoCode)
        {
            string result = "Cargo is exists already!";

            using (var db = new GetRateContext())
            {
                var cargoes = db.Cargoes;

                bool checkIsExist = cargoes.Any(co => co.NameENG == cargoNameENG);

                if (!checkIsExist)
                {
                    Cargo newCargo = new Cargo();
                    newCargo.NameENG = cargoNameENG;
                    newCargo.NameUKR = cargoNameUKR;
                    newCargo.Code = cargoCode;

                    cargoes.Add(newCargo);
                    db.SaveChanges();
                    result = $"Cargo {newCargo.NameENG} added successfully!";
                }

                return result;
            }
        }

        //edit Cargo
        public static string EditCargo(Cargo oldCargo, string newNameENG, string newNameUKR, string newCode)
        {
            string result = "There is no such cargo!";

            using (var db = new GetRateContext())
            {
                Cargo cargo = db.Cargoes.FirstOrDefault(c => c.Id == oldCargo.Id);

                if (cargo != null)
                {
                    cargo.NameENG = newNameENG;
                    cargo.NameUKR = newNameUKR;
                    cargo.Code = newCode;

                    db.SaveChanges();
                    result = $"Cargo {cargo.NameENG} is changed!";
                }
            }
            return result;
        }

        //delete Cargo
        public static string DeleteCargo(Cargo cargo)
        {
            string result = "There is no such cargo!";

            using (var db = new GetRateContext())
            {
                var cargoes = db.Cargoes;

                var deletedCargo = (from c in cargoes
                                      where c.Id == cargo.Id
                                      select c).FirstOrDefault();

                if (deletedCargo != null)
                {
                    db.Cargoes.Remove(deletedCargo);
                    db.SaveChanges();
                    result = $"Cargo {deletedCargo.NameENG} deleted!";
                }
            }
            return result;
        }

        //get Cargo by Id
        public static Cargo GetCargoById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.Cargoes.FirstOrDefault(c => c.Id == id);
            }
        }

        #endregion

        #region UNITTYPES
        //Get all unitTypes
        public static List<UnitType> GetAllUnitTypes()
        {
            using (var db = new GetRateContext())
            {
                var query = db.UnitTypes.AsQueryable().OrderBy(c => c.NameENG);

                return query.ToList();
            }
        }

        //create UnitType
        public static string CreateUnitType(string unitNameENG, string unitNameUKR, double unitMaxGrossWeight)
        {
            string result = "UnitType is exists already!";

            using (var db = new GetRateContext())
            {
                var types = db.UnitTypes;

                bool checkIsExist = types.Any(co => co.NameENG == unitNameENG);

                if (!checkIsExist)
                {
                    UnitType newUnitType = new UnitType();
                    newUnitType.NameENG = unitNameENG;
                    newUnitType.NameUKR = unitNameUKR;
                    newUnitType.MaximumGrossWeight = unitMaxGrossWeight;

                    types.Add(newUnitType);
                    db.SaveChanges();
                    result = $"UnitType {newUnitType.NameENG} added successfully!";
                }

                return result;
            }
        }

        //edit UnitType
        public static string EditUnitType(UnitType oldUnitType, string newNameENG, string newNameUKR, double newMaxGrossWeight)
        {
            string result = "There is no such UnitType!";

            using (var db = new GetRateContext())
            {
                UnitType unitType = db.UnitTypes.FirstOrDefault(c => c.Id == oldUnitType.Id);

                if (unitType != null)
                {
                    unitType.NameENG = newNameENG;
                    unitType.NameUKR = newNameUKR;
                    unitType.MaximumGrossWeight= newMaxGrossWeight;

                    db.SaveChanges();
                    result = "UnitType is changed!";
                }
            }
            return result;
        }

        //delete UnitType
        public static string DeleteUnitType(UnitType unitType)
        {
            string result = "There is no such UnitType!";

            using (var db = new GetRateContext())
            {
                var unitTypes = db.UnitTypes;

                var deletedUnitType = (from c in unitTypes
                                      where c.Id == unitType.Id
                                      select c).FirstOrDefault();

                if (deletedUnitType != null)
                {
                    db.UnitTypes.Remove(deletedUnitType);
                    db.SaveChanges();
                    result = $"UnitType {deletedUnitType.NameENG} deleted!";
                }
            }
            return result;
        }

        //get UnitType by Id
        public static UnitType GetUnitTypeById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.UnitTypes.FirstOrDefault(c => c.Id == id);
            }
        }
        #endregion

        #region TRANSPORT MODES
        //Get all Transport Modes
        public static List<TransportMode> GetAllTransportModes()
        {
            using (var db = new GetRateContext())
            {
                var query = db.TransportModes.AsQueryable().OrderBy(c => c.NameENG);

                return query.ToList();
            }
        }

        //create TransportMode
        public static string CreateTransportMode(string transportModeNameENG, string transportModeNameUKR)
        {
            string result = "TransportMode is exists already!";

            using (var db = new GetRateContext())
            {
                var modes = db.TransportModes;

                bool checkIsExist = modes.Any(co => co.NameENG == transportModeNameENG);

                if (!checkIsExist)
                {
                    TransportMode newTransportMode = new TransportMode();
                    newTransportMode.NameENG = transportModeNameENG;
                    newTransportMode.NameUKR = transportModeNameUKR;

                    modes.Add(newTransportMode);
                    db.SaveChanges();
                    result = $"TransportMode {newTransportMode.NameENG} added successfully!";
                }

                return result;
            }
        }

        //edit TransportMode
        public static string EditTransportMode(TransportMode oldTransportMode, string newNameENG, string newNameUKR)
        {
            string result = "There is no such TransportMode!";

            using (var db = new GetRateContext())
            {
                TransportMode transportMode = db.TransportModes.FirstOrDefault(c => c.Id == oldTransportMode.Id);

                if (transportMode != null)
                {
                    transportMode.NameENG = newNameENG;
                    transportMode.NameUKR = newNameUKR;

                    db.SaveChanges();
                    result = "TransportMode is changed!";
                }
            }
            return result;
        }

        //delete TransportMode
        public static string DeleteTransportMode(TransportMode transportMode)
        {
            string result = "There is no such TransportMode!";

            using (var db = new GetRateContext())
            {
                var modes = db.TransportModes;

                var deletedTransportMode = (from c in modes
                                       where c.Id == transportMode.Id
                                       select c).FirstOrDefault();

                if (deletedTransportMode != null)
                {
                    db.TransportModes.Remove(deletedTransportMode);
                    db.SaveChanges();
                    result = $"TransportMode {deletedTransportMode.NameENG} deleted!";
                }
            }
            return result;
        }

        //get TransportMode by Id
        public static TransportMode GetTransportModeById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.TransportModes.FirstOrDefault(c => c.Id == id);
            }
        }
        #endregion

        #region TRANSPORTMODESUNITTYPES
        //Get all TransportModesUnitTypes
        public static List<TransportModeUnitType> GetAllTransportModeUnitTypes()
        {
            using (var db = new GetRateContext())
            {
                var query = db.TransportModesUnitTypes.AsQueryable().OrderBy(c => c.TransportMode.NameENG);

                return query.ToList();
            }
        }

        //create TransportModeUnitType
        public static string CreateTransportModeUnitType(TransportMode transportMode, UnitType unitType)
        {
            string result = "TransportModeUnitType is exists already!";

            using (var db = new GetRateContext())
            {
                var tmuTypes = db.TransportModesUnitTypes;

                bool checkIsExist = tmuTypes.Any(co => co.TransportModeId == transportMode.Id && co.UnitTypeId == unitType.Id);

                if (!checkIsExist)
                {
                    TransportModeUnitType newTransportModeUnitType = new TransportModeUnitType();
                    newTransportModeUnitType.TransportModeId = transportMode.Id;
                    newTransportModeUnitType.UnitTypeId = unitType.Id;

                    tmuTypes.Add(newTransportModeUnitType);
                    db.SaveChanges();
                    result = $"TransportModeUnitType {newTransportModeUnitType.NameENG} added successfully!";
                }

                return result;
            }
        }

        //edit TransportModeUnitType
        public static string EditTransportModeUnitType(TransportModeUnitType oldTransportModeUnitType, TransportMode transportMode, UnitType unitType)
        {
            string result = "There is no such TransportModeUnitType!";

            using (var db = new GetRateContext())
            {
                TransportModeUnitType transportModeUnitType = db.TransportModesUnitTypes.FirstOrDefault(c => c.Id == oldTransportModeUnitType.Id);

                if (transportModeUnitType != null)
                {
                    transportModeUnitType.TransportModeId = transportMode.Id;
                    transportModeUnitType.UnitTypeId = unitType.Id;

                    db.SaveChanges();
                    result = "TransportModeUnitType is changed!";
                }
            }
            return result;
        }

        //delete TransportModeUnitType
        public static string DeleteTransportModeUnitType(TransportModeUnitType transportModeUnitType)
        {
            string result = "There is no such TransportModeUnitType!";

            using (var db = new GetRateContext())
            {
                var modes = db.TransportModesUnitTypes;

                var deletedTransportModeUnitType = (from c in modes
                                            where c.Id == transportModeUnitType.Id
                                            select c).FirstOrDefault();

                if (deletedTransportModeUnitType != null)
                {
                    db.TransportModesUnitTypes.Remove(deletedTransportModeUnitType);
                    db.SaveChanges();
                    result = $"TransportMode {deletedTransportModeUnitType.NameENG} deleted!";
                }
            }
            return result;
        }

        //get TransportModeUnitType by Id
        public static TransportModeUnitType GetTransportModeUnitTypeById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.TransportModesUnitTypes.FirstOrDefault(c => c.Id == id);
            }
        }
        #endregion
    }
}
