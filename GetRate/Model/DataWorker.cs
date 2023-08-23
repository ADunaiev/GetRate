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
                var query = from country in countries
                            orderby country.NameENG
                            select country;                 
                  
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

        public static string CreateRoutePoint(Company company)
        {
            string result = "RoutePoint is already exists!";

            using (var db = new GetRateContext()) 
            {
                bool isExists = db.RoutePoints.Any(rp => rp.CompanyId == company.Id);

                if (!isExists)
                {
                    RoutePoint routePoint = new RoutePoint();
                    routePoint.CompanyId = company.Id;

                    db.RoutePoints.Add(routePoint);
                    db.SaveChanges();
                    result = $"RoutePoint is created!";
                }

            }
                
            return result;
        }

        //edit RoutePoint
        public static string EditRoutePoint(RoutePoint oldRoutePoint, Company newCompany)
        {
            string result = "There is no such RoutePoint!";

            using (var db = new GetRateContext())
            {
                RoutePoint routePoint = db.RoutePoints.FirstOrDefault(rp => rp.Id == oldRoutePoint.Id);

                if (routePoint != null)
                {
                    routePoint.CompanyId = newCompany.Id;

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

        #region PACKAGE

        //Get all Packages
        public static List<Package> GetAllPackages()
        {
            using (var db = new GetRateContext())
            {
                var query = db.Packages.AsQueryable().OrderBy(c => c.NameENG);

                return query.ToList();
            }
        }

        //create Package
        public static string CreatePackage(string packageNameENG, string packageNameUKR, decimal grossWeight, decimal packageGW)
        {
            string result = "Package is exists already!";

            using (var db = new GetRateContext())
            {
                var packages = db.Packages;

                bool checkIsExist = packages.Any(co => co.NameENG == packageNameENG);

                if (!checkIsExist)
                {
                    Package newPackage = new Package();
                    newPackage.NameENG = packageNameENG;
                    newPackage.NameUKR = packageNameUKR;
                    newPackage.Payload = grossWeight;
                    newPackage.PackageWeight = packageGW;

                    packages.Add(newPackage);
                    db.SaveChanges();
                    result = $"Package {newPackage.NameENG} added successfully!";
                }

                return result;
            }
        }

        //edit Package
        public static string EditPackage(Package oldPackage, string newNameENG, string newNameUKR, decimal newGrossWeight, decimal newPackageWeight)
        {
            string result = "There is no such package!";

            using (var db = new GetRateContext())
            {
                Package package = db.Packages.FirstOrDefault(c => c.Id == oldPackage.Id);

                if (package != null)
                {
                    package.NameENG = newNameENG;
                    package.NameUKR = newNameUKR;
                    package.Payload = newGrossWeight;
                    package.PackageWeight = newPackageWeight;

                    db.SaveChanges();
                    result = $"Package {package.NameENG} is changed!";
                }
            }
            return result;
        }

        //delete Package
        public static string DeletePackage(Package package)
        {
            string result = "There is no such package!";

            using (var db = new GetRateContext())
            {
                var packages = db.Packages;

                var deletedPackage = (from c in packages
                                    where c.Id == package.Id
                                    select c).FirstOrDefault();

                if (deletedPackage != null)
                {
                    db.Packages.Remove(deletedPackage);
                    db.SaveChanges();
                    result = $"Package {deletedPackage.NameENG} deleted!";
                }
            }
            return result;
        }

        //get Package by Id
        public static Package GetPackageById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.Packages.FirstOrDefault(c => c.Id == id);
            }
        }

        #endregion

        #region CARGO_PACKAGE

        //Get all CargoPackages
        public static List<CargoPackage> GetAllCargoPackages()
        {
            using (var db = new GetRateContext())
            {
                var cargoPackages = db.CargoPackages;
                var cargoes = db.Cargoes;
                var query = from c in cargoPackages
                            join ca in cargoes
                            on c.CargoId equals ca.Id
                            orderby ca.NameENG
                            select c;

                return query.ToList();
            }
        }

        //create CargoPackage
        public static string CreateCargoPackage(Cargo cargo, Package package)
        {
            string result = "CargoPackage is exists already!";

            using (var db = new GetRateContext())
            {
                var cargoPackages = db.CargoPackages;

                bool checkIsExist = cargoPackages.Any(cp => cp.CargoId == cargo.Id && cp.PackageId == package.Id);

                if (!checkIsExist)
                {
                    CargoPackage newCargoPackage = new CargoPackage();
                    newCargoPackage.CargoId = cargo.Id;
                    newCargoPackage.PackageId  = package.Id;

                    cargoPackages.Add(newCargoPackage);
                    db.SaveChanges();
                    result = $"CargoPackage {newCargoPackage.NameENG} added successfully!";
                }

                return result;
            }
        }

        //edit CargoPackage
        public static string EditCargoPackage(CargoPackage oldCargoPackage, Cargo newCargo, Package newPackage)
        {
            string result = "There is no such CargoPackage!";

            using (var db = new GetRateContext())
            {
                CargoPackage cargoPackage = db.CargoPackages.FirstOrDefault(c => c.Id == oldCargoPackage.Id);

                if (cargoPackage != null)
                {
                    cargoPackage.CargoId = newCargo.Id;
                    cargoPackage.PackageId = newPackage.Id;

                    db.SaveChanges();
                    result = $"CargoPackage {cargoPackage.NameENG} is changed!";
                }
            }
            return result;
        }

        //delete CargoPackage
        public static string DeleteCargoPackage(CargoPackage cargoPackage)
        {
            string result = "There is no such CargoPackage!";

            using (var db = new GetRateContext())
            {
                var cargoPackages = db.CargoPackages;

                var deletedCargoPackage = (from c in cargoPackages
                                      where c.Id == cargoPackage.Id
                                      select c).FirstOrDefault();

                if (deletedCargoPackage != null)
                {
                    db.CargoPackages.Remove(deletedCargoPackage);
                    db.SaveChanges();
                    result = $"CargoPackage {deletedCargoPackage.NameENG} deleted!";
                }
            }
            return result;
        }

        //get Package by Id
        public static CargoPackage GetCargoPackageById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.CargoPackages.FirstOrDefault(c => c.Id == id);
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

        #region TRANSPORTMODES_UNITTYPES
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

        #region TRANSPORTATION_TYPES
        //Get all TransportationTypes
        public static List<TransportationType> GetAllTransportationTypes()
        {
            using (var db = new GetRateContext())
            {
                var tTypes = db.TransportationTypes;

                var query = from type in tTypes                          
                            select type;

                return query.ToList();
            }
        }

        //create TransportationType
        public static string CreateTransportationType(TransportModeUnitType transportModeUnitType, RoutePoint fromRoutePoint, RoutePoint toRoutePoint)
        {
            string result = "TransportationType is exists already!";

            using (var db = new GetRateContext())
            {
                var transTypes = db.TransportationTypes;

                bool checkIsExist = transTypes.Any(tt => tt.TransportModeUnitTypeId == transportModeUnitType.Id 
                                                    && tt.FromRoutePointId == fromRoutePoint.Id
                                                    && tt.ToRoutePointId == toRoutePoint.Id);

                if (!checkIsExist)
                {
                    TransportationType newTransportationType = new TransportationType();
                    newTransportationType.TransportModeUnitTypeId = transportModeUnitType.Id;
                    newTransportationType.FromRoutePointId = fromRoutePoint.Id;
                    newTransportationType.ToRoutePointId = toRoutePoint.Id;

                    transTypes.Add(newTransportationType);
                    db.SaveChanges();
                    result = $"TransportationType added successfully!";
                }

                return result;
            }
        }

        //edit TransportationtType
        public static string EditTransportationType(TransportationType oldTransportationtType, TransportModeUnitType newTMUT, RoutePoint newFromRP, RoutePoint newToRP)
        {
            string result = "There is no such TransportationType!";

            using (var db = new GetRateContext())
            {
                TransportationType transportationType = db.TransportationTypes.FirstOrDefault(c => c.Id == oldTransportationtType.Id);

                if (transportationType != null)
                {
                    transportationType.TransportModeUnitTypeId = newTMUT.Id;
                    transportationType.FromRoutePointId = newFromRP.Id;
                    transportationType.ToRoutePointId= newToRP.Id;

                    db.SaveChanges();
                    result = "TransportModeUnitType is changed!";
                }
            }
            return result;
        }

        //delete TransportationType
        public static string DeleteTransportationType(TransportationType deletedTransportationType)
        {
            string result = "There is no such TransportationType!";

            using (var db = new GetRateContext())
            {
                var modes = db.TransportationTypes;

                var deletedType = (from c in modes
                                                    where c.Id == deletedTransportationType.Id
                                                    select c).FirstOrDefault();

                if (deletedType != null)
                {
                    db.TransportationTypes.Remove(deletedType);
                    db.SaveChanges();
                    result = $"TransportationType deleted!";
                }
            }
            return result;
        }

        //get TransportationType by Id
        public static TransportationType GetTransportationTypeById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.TransportationTypes.FirstOrDefault(c => c.Id == id);
            }
        }
        #endregion

        //#region ROUTEPOINT_TRANSPORTMODE_UNITTYPES
        ////Get all RoutePointTransportModesUnitTypes = RPTMUT
        //public static List<RoutePointTransportModeUnitType> GetAllRPTMUT()
        //{
        //    using (var db = new GetRateContext())
        //    {
        //        var query = db.RoutePointTransportModeUnitTypes.AsQueryable().OrderBy(c => c.RoutePoint.Company.NameENG);

        //        return query.ToList();
        //    }
        //}

        ////create RoutePointTransportModeUnitType
        //public static string CreateRPTMUT(TransportModeUnitType tMUT, RoutePoint routePoint)
        //{
        //    string result = "RoutePointTransportModeUnitType is exists already!";

        //    using (var db = new GetRateContext())
        //    {
        //        var tmuTypes = db.RoutePointTransportModeUnitTypes;

        //        bool checkIsExist = tmuTypes.Any(co => co.RoutePointId == routePoint.Id && co.TransportModeUnitTypeId == tMUT.Id);

        //        if (!checkIsExist)
        //        {
        //            RoutePointTransportModeUnitType newRPTMUT = new RoutePointTransportModeUnitType();
        //            newRPTMUT.TransportModeUnitTypeId = tMUT.Id;
        //            newRPTMUT.RoutePointId = routePoint.Id;

        //            tmuTypes.Add(newRPTMUT);
        //            db.SaveChanges();
        //            result = $"RoutePointTransportModeUnitType {newRPTMUT.RoutePointNameENG} added successfully!";
        //        }

        //        return result;
        //    }
        //}

        ////edit RoutePointTransportModeUnitType
        //public static string EditRPTMUT(RoutePointTransportModeUnitType oldRPTMUT, RoutePoint routePoint, TransportModeUnitType tMUT)
        //{
        //    string result = "There is no such RoutePointTransportModeUnitType!";

        //    using (var db = new GetRateContext())
        //    {
        //        var rptmutypes = db.RoutePointTransportModeUnitTypes;
        //        RoutePointTransportModeUnitType transportModeUnitType = rptmutypes.FirstOrDefault(c => c.Id == oldRPTMUT.Id);

        //        if (transportModeUnitType != null)
        //        {

        //            bool checkIsExist = rptmutypes.Any(co => co.RoutePointId == routePoint.Id && co.TransportModeUnitTypeId == tMUT.Id);

        //            if (checkIsExist)
        //            {
        //                result = "This item exists allready in database";
        //            }
        //            else
        //            {
        //                transportModeUnitType.RoutePointId = routePoint.Id;
        //                transportModeUnitType.TransportModeUnitTypeId = tMUT.Id;

        //                db.SaveChanges();
        //                result = "RoutePointTransportModeUnitType is changed!";
        //            }

        //        }
        //    }
        //    return result;
        //}

        ////delete RoutePointTransportModeUnitType
        //public static string DeleteRPTMUT(RoutePointTransportModeUnitType rptmutype)
        //{
        //    string result = "There is no such RoutePointTransportModeUnitType!";

        //    using (var db = new GetRateContext())
        //    {
        //        var rptmutypes = db.RoutePointTransportModeUnitTypes;

        //        var deletedTransportModeUnitType = (from c in rptmutypes
        //                                            where c.Id == rptmutype.Id
        //                                            select c).FirstOrDefault();

        //        if (deletedTransportModeUnitType != null)
        //        {
        //            rptmutypes.Remove(deletedTransportModeUnitType);
        //            db.SaveChanges();
        //            result = $"RoutePointTransportModeUnitType deleted!";
        //        }
        //    }
        //    return result;
        //}

        ////get RoutePointTransportModeUnitType by Id
        //public static RoutePointTransportModeUnitType GetRPTMUTbyId(int id)
        //{
        //    using (var db = new GetRateContext())
        //    {
        //        return db.RoutePointTransportModeUnitTypes.FirstOrDefault(c => c.Id == id);
        //    }
        //}
        //#endregion

        #region REQUEST

        //Get all Requests
        public static List<Request> GetAllRequests()
        {
            using (var db = new GetRateContext())
            {
                var requests = db.Requests;

                var query = from c in requests
                            select c;

                return query.ToList();
            }
        }

        //create Request
        public static string CreateRequest(Company customer, CargoPackage fromCargoPackage, City fromCity, RoutePoint fromRoutePoint, bool fromHandlingNeeded,
            CargoPackage toCargoPackage, City toCity, RoutePoint toRoutePoint, bool toHandlingNeeded, decimal cargoGrossWeight, decimal cargoVolume)
        {
            string result = "";

            using (var db = new GetRateContext())
            {
                var requests = db.Requests;


                Request newRequest = new Request();
                newRequest.CompanyId = customer.Id;
                newRequest.FromCargoPackageId = fromCargoPackage.Id;
                newRequest.FromCityId = fromCity.Id;    
                newRequest.FromRoutePointId = fromRoutePoint.Id;
                newRequest.FromHandlingNeeded = fromHandlingNeeded;
                newRequest.ToCargoPackageId = toCargoPackage.Id;
                newRequest.ToCityId = toCity.Id;
                newRequest.ToRoutePointId = toRoutePoint.Id;
                newRequest.ToHandlingNeeded = toHandlingNeeded;
                newRequest.Date = System.DateTime.Now;
                newRequest.CargoGW = cargoGrossWeight;
                newRequest.CargoVolume = cargoVolume;

                requests.Add(newRequest);
                db.SaveChanges();
                result = $"Request added successfully!";
                
                return result;
            }
        }

        //edit Request
        public static string EditRequest
            (
                Request oldRequest, 
                Company newCompany,
                CargoPackage newFromCargoPackage,
                City newFromCity,
                RoutePoint newFromRoutePoint,
                bool newFromHandlingNeeded,
                CargoPackage newToCargoPackage,
                City newToCity,
                RoutePoint newToRoutePoint,
                bool newToHandlingNeeded,
                decimal newCargoGrossWeight,
                decimal newCargoVolume
            )
        {
            string result = "There is no such Request!";

            using (var db = new GetRateContext())
            {
                Request request = db.Requests.FirstOrDefault(c => c.Id == oldRequest.Id);

                if (request != null)
                {
                    request.CompanyId = newCompany.Id;
                    request.FromRoutePointId = newFromRoutePoint.Id;
                    request.ToRoutePointId = newToRoutePoint.Id;
                    request.FromCityId = newFromCity.Id;
                    request.ToCityId = newToCity.Id;
                    request.FromCargoPackageId = newFromCargoPackage.Id;
                    request.ToCargoPackageId = newToCargoPackage.Id;
                    request.FromHandlingNeeded = newFromHandlingNeeded;
                    request.ToHandlingNeeded = newToHandlingNeeded;
                    request.CargoGW = newCargoGrossWeight;
                    request.CargoVolume = newCargoVolume;

                    db.SaveChanges();
                    result = $"Request {request.Id} is changed!";
                }
            }
            return result;
        }

        //delete Request
        public static string DeleteRequest(Request request)
        {
            string result = "There is no such Request!";

            using (var db = new GetRateContext())
            {
                var requests = db.Requests;

                var deletedRequest = (from c in requests
                                           where c.Id == request.Id
                                           select c).FirstOrDefault();

                if (deletedRequest != null)
                {
                    requests.Remove(deletedRequest);
                    db.SaveChanges();
                    result = $"Request deleted!";
                }
            }
            return result;
        }

        //get Request by Id
        public static Request GetRequestById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.Requests.FirstOrDefault(c => c.Id == id);
            }
        }

        #endregion

        #region REQUEST_TRANSPORTATIONTYPE

        //Get all RequestTransportationTypes
        public static List<RequestTransportationType> GetAllRequestTT()
        {
            using (var db = new GetRateContext())
            {
                var types = db.RequestTransportationTypes;
                var requests = db.Requests;

                var query = from type in types
                            join request in requests
                            on type.RequestId equals request.Id
                            orderby request.Id
                            select type;

                return query.ToList();
            }
        }

        //create RequestTT
        public static string CreateRequestTT(Request request, TransportationType transportationType, int option, int subOption)
        {
            string result = "RequestTransportationType is exists already!";

            using (var db = new GetRateContext())
            {
                var rTTypes = db.RequestTransportationTypes;

                bool checkIsExist = rTTypes.Any(rtt => rtt.RequestId == request.Id 
                        && rtt.TransportationTypeId == transportationType.Id
                        && rtt.Option == option
                        && rtt.SubOption == subOption);

                if (!checkIsExist)
                {
                    RequestTransportationType newRequestTT = new RequestTransportationType();
                    newRequestTT.RequestId = request.Id;
                    newRequestTT.TransportationTypeId = transportationType.Id;
                    newRequestTT.Option = option;
                    newRequestTT.SubOption = subOption;

                    rTTypes.Add(newRequestTT);
                    db.SaveChanges();
                    result = $"RequestTransportationType added successfully!";
                }

                return result;
            }
        }

        //edit RequestTT
        public static string EditRequestTT(RequestTransportationType oldRequestTT, Request newRequest, TransportationType newTT, int newOption, int newSubOption)
        {
            string result = "There is no such RequestTransportationType!";

            using (var db = new GetRateContext())
            {
                RequestTransportationType requestTT = db.RequestTransportationTypes.FirstOrDefault(c => c.Id == oldRequestTT.Id);

                if (requestTT != null)
                {
                    requestTT.RequestId = newRequest.Id;
                    requestTT.TransportationTypeId = newTT.Id;
                    requestTT.Option = newOption;
                    requestTT.SubOption = newSubOption;

                    db.SaveChanges();
                    result = $"RequestTransportationType is changed!";
                }
            }
            return result;
        }

        //delete RequestTT
        public static string DeleteRequestTT(RequestTransportationType requestTT)
        {
            string result = "There is no such RequestTransportationType!";

            using (var db = new GetRateContext())
            {
                var rTTypes = db.RequestTransportationTypes;

                var deletedRequestTT = (from rtt in rTTypes
                                           where rtt.Id == requestTT.Id
                                           select rtt).FirstOrDefault();

                if (deletedRequestTT != null)
                {
                    rTTypes.Remove(deletedRequestTT);
                    db.SaveChanges();
                    result = $"RequestTransportationType deleted!";
                }
            }
            return result;
        }

        //get RequestTT by Id
        public static RequestTransportationType GetRequestTTById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.RequestTransportationTypes.FirstOrDefault(c => c.Id == id);
            }
        }



        #endregion

        #region HANDLING
        //Get all Handlings
        public static List<Handling> GetAllHandlings()
        {
            using (var db = new GetRateContext())
            {
                var handlings = db.Handlings;

                var query = from handling in handlings
                            select handling;

                return query.ToList();
            }
        }

        //create Handling
        public static string CreateHandling(TransportModeUnitType tMUT_In, TransportModeUnitType tMUT_Out, RoutePoint routePoint)
        {
            string result = "Handling is exists already!";

            using (var db = new GetRateContext())
            {
                var handlings = db.Handlings;

                bool checkIsExist = handlings.Any(h => h.TMUT_InId == tMUT_In.Id
                                                    && h.TMUT_OutId == tMUT_Out.Id
                                                    && h.RoutePointId == routePoint.Id);

                if (!checkIsExist)
                {
                    Handling newHandlng = new Handling();
                    newHandlng.TMUT_InId = tMUT_In.Id;
                    newHandlng.TMUT_OutId = tMUT_Out.Id;
                    newHandlng.RoutePointId = routePoint.Id;

                    handlings.Add(newHandlng);
                    db.SaveChanges();
                    result = $"Handling added successfully!";
                }

                return result;
            }
        }

        //edit Handling
        public static string EditHandling(Handling oldHandling, TransportModeUnitType newTMUT_In, TransportModeUnitType newTMUT_Out, RoutePoint newRoutePoint)
        {
            string result = "There is no such Handling!";

            using (var db = new GetRateContext())
            {
                Handling handling = db.Handlings.FirstOrDefault(h => h.Id == oldHandling.Id);

                if (handling != null)
                {
                    handling.TMUT_InId = newTMUT_In.Id;
                    handling.TMUT_OutId = newTMUT_Out.Id;
                    handling.RoutePointId = newRoutePoint.Id;

                    db.SaveChanges();
                    result = "Handling is changed!";
                }
            }
            return result;
        }

        //delete Handling
        public static string DeleteHandling(Handling oldHandling)
        {
            string result = "There is no such Handling!";

            using (var db = new GetRateContext())
            {
                var handlings = db.Handlings;

                var deletedHandling = (from h in handlings
                                   where h.Id == oldHandling.Id
                                   select h).FirstOrDefault();

                if (deletedHandling != null)
                {
                    handlings.Remove(deletedHandling);
                    db.SaveChanges();
                    result = $"Handling deleted!";
                }
            }
            return result;
        }

        //get Handling by Id
        public static Handling GetHandlingById(int id)
        {
            using (var db = new GetRateContext())
            {
                return db.Handlings.FirstOrDefault(h => h.Id == id);
            }
        }
        #endregion
    }
}
