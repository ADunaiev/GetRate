using GetRate.Model;
using GetRate.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GetRate.ViewModel
{
    internal class DataManageVM : INotifyPropertyChanged
    {
        #region ALL ESSENSES
        //all countries
        private List<Country> allCountries = DataWorker.GetAllCountries();
        public List<Country> AllCountries 
        { 
            get { return allCountries; }
            set { 
                    allCountries = value; 
                    NotifyPropertyChanged("AllCountries");
                }
        }

        //all cities
        private List<City> allCities = DataWorker.GetAllCities();
        public List<City> AllCities
        {
            get { return allCities; }
            set
            {
                allCities = value;
                NotifyPropertyChanged("AllCities");
            }
        }

        //all addresses
        private List<Address> allAddresses = DataWorker.GetAlAddresses();
        public List<Address> AllAddresses
        {
            get { return allAddresses; }
            set
            {
                allAddresses = value;
                NotifyPropertyChanged("AllAddresses");
            }
        }

        //all companies
        private List<Company> allCompanies = DataWorker.GetAllCompanies();
        public List<Company> AllCompanies
        {
            get { return allCompanies; }
            set
            {
                allCompanies = value;
                NotifyPropertyChanged("AllCompanies");
            }
        }
        public static List<string> AllCompanyTypes
        {
            get 
            {
                List<string> types = new List<string>();

                Array iTypes = Enum.GetValues(typeof(CompanyType));

                foreach (int value in iTypes) 
                {
                    types.Add(((CompanyType)value).ToString());
                }

                return types;
            }
        }

        //all TransportModes

        private List<TransportMode> allTransportModes = DataWorker.GetAllTransportModes();
        public List<TransportMode> AllTransportModes
        {
            get
            {
                return allTransportModes;
            }
            set
            { 
                allTransportModes = value;
                NotifyPropertyChanged("AllTransportModes");
            }
        }

        //all TransportModesUnitTypes

        private List<TransportModeUnitType> allTransportModesUnitTypes = DataWorker.GetAllTransportModeUnitTypes();
        public List<TransportModeUnitType> AllTransportModesUnitTypes
        {
            get
            {  return allTransportModesUnitTypes;}
            set
            {
                allTransportModesUnitTypes = value;
                NotifyPropertyChanged("AllTransportModeUnitTypes");
            }
        }

        //all unitTypes

        private List<UnitType> allUnitTypes = DataWorker.GetAllUnitTypes();
        public List<UnitType> AllUnitTypes
        {
            get
            { return allUnitTypes; }
            set
            {
                allUnitTypes = value;
                NotifyPropertyChanged("AllUnitTypes");
            }
        }

        //All Cargoes
        private List<Cargo> allCargoes = DataWorker.GetAllCargoes();
        public List<Cargo> AllCargoes
        {
            get { return allCargoes; }
            set
            {
                allCargoes = value;
                NotifyPropertyChanged("AllCargoes");
            }
        }

        //All RoutePoints
        private List<RoutePoint> allRoutePoints = DataWorker.GetAllRoutePoints();
        public List<RoutePoint> AllRoutePoints
        {
            get { return allRoutePoints; }
            set
            {
                allRoutePoints = value;
                NotifyPropertyChanged("AllRoutePoints");
            }
        }
        #endregion

        #region CLASS PROPERTIES
        //Countries properties
        public static string CountryNameENG { get; set; }
        public static string CountryNameUKR { get; set; }
        public static int CountryId { get; set; }

        //Cities properties
        public static int CityId { get; set; }
        public static string CityNameENG { get; set; }
        public static string CityNameUKR { get; set; }
        public static Country CityCountry { get; set; }

        //Addresses properties
        public static int AddressId { get; set; }
        public static string AddressNameENG { get; set; }
        public static string AddressNameUKR { get; set; }
        public static City AddressCity { get; set; }

        //Companies properties
        public static int CompanyId { get; set; }
        public static string CompanyNameENG { get; set; }
        public static string CompanyNameUKR { get; set; }
        public static Address CompanyAddress { get; set; }

        private CompanyType _companyType;
        public CompanyType Company_Type 
        { 
            get { return _companyType; }
            set
            {
                _companyType = (CompanyType) value;

            }
        }

        //UnitTypes Properties
        public static int UnitTypeId { get; set; }
        public static string UnitTypeNameENG { get; set; }
        public static string UnitTypeNameUKR { get; set; }
        public static double UnitTypeMaxGW { get; set; }

        //TransportModes Properties
        public static int TransportModeId { get; set; }
        public static string TransportModeNameENG { get; set; }
        public static string TransportModeNameUKR { get; set; }

        //TransportModesUnitTypes Properties
        public static int TransportModeUnitTypeId { get; set; }
        public static TransportMode TMUTMode { get; set; }
        public static UnitType TMUTType { get; set; }

        //Cargoes Properties
        public static int CargoId { get; set; }
        public static string CargoNameENG { get; set; }
        public static string CargoNameUKR { get; set; }
        public static string CargoCode { get; set; }

        //RoutePoint Properties
        public static int RoutePointId { get; set; }
        public static Company RoutePointCompany { get; set; }
        public static List<TransportMode> RoutePointTransportModes { get; set; }
        public static ObservableCollection<UnitType> RoutePointUnitTypes { get; set; }
        #endregion

        #region SELECTED ITEMS
        //Selection properties
        public static Address SelectedAddress { get; set; }
        public static City SelectedCity { get; set; }
        public static Country SelectedCountry { get; set; }
        public static Company SelectedCompany { get; set; }
        public static UnitType SelectedUnitType { get; set; }
        public static Cargo SelectedCargo { get; set; }
        public static TransportMode SelectedTransportMode { get; set; }
        public static TransportModeUnitType SelectedTMUT { get; set; }
        public static RoutePoint SelectedRoutePoint { get; set; }
        public static ObservableCollection<UnitType> RoutePointSelectedUnitTypes { get; set; }
        #endregion

        #region COMMANDS TO ADD

        //Countries
        private RelayCommand addNewCountry;
        public RelayCommand AddNewCountry
        {
            get
            {
                return addNewCountry ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = string.Empty;

                    if (CountryNameENG == null || CountryNameENG.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControl(window, "CountryNameENGTextBox");
                    }
                    if (CountryNameUKR == null || CountryNameUKR.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControl(window, "CountryNameUKRTextBox");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateCountry(CountryNameENG, CountryNameUKR);
                        UpdateCountriesView();
                        ShowMessageToUser(resultStr);
                        SetNullValuesToProperties();
                        window.Close();
                    }
                   
                }
                    );
            }
        }

        //Cities
        private RelayCommand addNewCity;
        public RelayCommand AddNewCity
        {
            get
            {
                return addNewCity ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = string.Empty;

                    if (CityNameENG == null || CityNameENG.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControl(window, "CityNameENGTextBox");
                    }
                    if (CityNameUKR == null || CityNameUKR.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControl(window, "CityNameUKRTextBox");
                    }
                    if (CityCountry == null)
                    {
                        MessageBox.Show("Please choose Country!");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateCity(CityNameENG, CityNameUKR, CityCountry);
                        UpdateCitiesView();

                        ShowMessageToUser(resultStr);
                        SetNullValuesToProperties();
                        window.Close();
                    }
                    
                });
            }
        }

        //Addresses
        private RelayCommand addNewAddress;
        public RelayCommand AddNewAddress
        {
            get
            {
                return addNewAddress ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = string.Empty;

                    if (AddressNameENG == null || AddressNameENG.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControl(window, "StreetNameENGTextBox");
                    }
                    if (AddressNameUKR == null || AddressNameUKR.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControl(window, "StreetNameUKRTextBox");
                    }
                    if (AddressCity == null)
                    {
                        MessageBox.Show("Please choose City!");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateAddress(AddressNameENG, AddressNameUKR, AddressCity);
                        UpdateAddressesView();
                        ShowMessageToUser(resultStr);
                        SetNullValuesToProperties();
                        window.Close();
                    }

                });
            }
        }

        //Companies
        private RelayCommand addNewCompany;
        public RelayCommand AddNewCompany
        {
            get
            {
                return addNewCompany ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = string.Empty;

                    if (string.IsNullOrEmpty(CompanyNameENG))
                    {
                        SetRedBlockControl(window, "CompanyNameENGTextBox");
                    }
                    if (string.IsNullOrEmpty(AddressNameUKR))
                    {
                        SetRedBlockControl(window, "CompanyNameUKRTextBox");
                    }
                    if (CompanyAddress == null)
                    {
                        ShowMessageToUser("Please choose company address!");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateCompany(CompanyNameENG, CompanyNameUKR, CompanyAddress, Company_Type);
                        UpdateCompaniesView();
                        SetNullValuesToProperties();
                        ShowMessageToUser(resultStr);
                        window.Close();
                    }

                });
            }
        }

        //UnitTypes
        private RelayCommand addNewUnitType;
        public RelayCommand AddNewUnitType
        {
            get
            {
                return addNewUnitType ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = string.Empty;

                    if (string.IsNullOrEmpty(UnitTypeNameENG))
                    {
                        SetRedBlockControl(window, "UnitTypeNameENGTextBox");
                    }
                    if (string.IsNullOrEmpty(UnitTypeNameUKR))
                    { 
                        SetRedBlockControl(window, "UnitTypeNameUKRTextBox"); 
                    }
                    if (UnitTypeMaxGW == 0)
                    {
                        SetRedBlockControl(window, "UnitTypeMaxGWTextBox");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateUnitType(UnitTypeNameENG, UnitTypeNameUKR, UnitTypeMaxGW);
                        UpdateUnitTypesView();
                        SetNullValuesToProperties();
                        ShowMessageToUser(resultStr);
                        window.Close();
                    }
                });
            }
        }

        //TransportModes

        private RelayCommand addNewTransportMode; 
        public RelayCommand AddNewTransportMode
        {
            get
            {
                return addNewTransportMode ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = string.Empty;

                    if(string.IsNullOrEmpty(TransportModeNameENG))
                    {
                        SetRedBlockControl(window, "TransportModeNameENGBtn");
                    }
                    if(string.IsNullOrEmpty(TransportModeNameUKR))
                    {
                        SetRedBlockControl(window, "TransportModeNameUKRBtn");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateTransportMode(TransportModeNameENG, TransportModeNameUKR);
                        UpdateTransportModesView();
                        SetNullValuesToProperties();
                        ShowMessageToUser(resultStr);
                        window.Close();
                    }
                });
            }
        }

        //TransportModesUnitTypes
        private RelayCommand addNewTransportModeUnitType;
        public RelayCommand AddNewTransportModeUnitType
        {
            get
            {
                return addNewTransportModeUnitType ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = string.Empty;

                    if (TMUTMode == null)
                    {
                        ShowMessageToUser("Please choose TransportMode");
                    }
                    if (TMUTType == null)
                    {
                        ShowMessageToUser("Please choose UnitType");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateTransportModeUnitType(TMUTMode, TMUTType);
                        UpdateTMUTView();
                        SetNullValuesToProperties();
                        ShowMessageToUser(resultStr);
                        window.Close();
                    }
                });
            }
        }

        //Cargoes
        private RelayCommand addNewCargo;
        public RelayCommand AddNewCargo
        {
            get
            {
                return addNewCargo ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = string.Empty;

                    if (string.IsNullOrEmpty(CargoNameENG))
                    {
                        SetRedBlockControl(window, "CargoNameENGTextBox");
                    }
                    if (string.IsNullOrEmpty(CargoNameUKR))
                    {
                        SetRedBlockControl(window, "CargoNameUKRTextBox");
                    }
                    if (string.IsNullOrEmpty(CargoCode))
                    {
                        SetRedBlockControl(window, "CargoCodeTextBox");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateCargo(CargoNameENG, CargoNameUKR, CargoCode);
                        UpdateCargoesView();
                        SetNullValuesToProperties();
                        ShowMessageToUser(resultStr);
                        window.Close();
                    }
                });
            }
        }

        //RoutePoints
        private RelayCommand addNewRoutePoint;
        public RelayCommand AddNewRoutePoint
        {
            get
            {
                return addNewRoutePoint ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = string.Empty;

                    if (RoutePointCompany == null)
                    {
                        SetRedBlockControl(window, "RoutePointCompanyComboBox");
                    }
                    else
                    {

                        //resultStr = DataWorker.CreateRoutePoint(RoutePointCompany, RoutePointTransportModes, RoutePointSelectedUnitTypes);
                        //UpdateRoutePointsView();
                        //SetNullValuesToProperties();
                        if (RoutePointSelectedUnitTypes == null)
                        {
                            ShowMessageToUser("Empty collection");
                        }
                        else
                        {
                            foreach (var item in RoutePointSelectedUnitTypes)
                                ShowMessageToUser(item.NameENG + " ");
                        }
                        //window.Close();
                    }
                });
            }
        }

        #endregion

        #region COMMANDS TO OPEN WINDOWS

        //Countries
        private RelayCommand openAddNewCountryWnd;
        public RelayCommand OpenAddNewCountryWnd
        { 
            get 
            { 
                return openAddNewCountryWnd ?? new RelayCommand(obj =>
                    {
                        OpenAddCountriesWindowMethod();
                    }                                       
                    );          
            } 
        }

        private RelayCommand openEditCountryWnd;
        public RelayCommand OpenEditCountryWnd
        {
            get
            {
                return openEditCountryWnd ?? new RelayCommand(obj =>
                {
                    OpenEditCountryWindowMethod();
                }
                );
            }
        }

        private RelayCommand openCountriesListWnd;
        public RelayCommand OpenCountriesListWnd
        {
            get
            {
                return openCountriesListWnd ?? new RelayCommand(obj =>
                {
                    OpenCountriesListWindowMethod();
                }
                );
            }
        }

        //Cities
        private RelayCommand openAddNewCityWnd;
        public RelayCommand OpenAddNewCityWnd
        {
            get
            {
                return openAddNewCityWnd ?? new RelayCommand(obj =>
                {
                    OpenAddCitiesWindowMethod();
                }
                    );
            }
        }

        private RelayCommand openEditCityWnd;
        public RelayCommand OpenEditCityWnd
        {
            get
            {
                return openEditCityWnd ?? new RelayCommand(obj =>
                {
                    OpenEditCityWindowMethod();
                }
                );
            }
        }

        private RelayCommand openCitiesListWnd;
        public RelayCommand OpenCitiesListWnd
        {
            get
            {
                return openCitiesListWnd ?? new RelayCommand(obj =>
                {
                    OpenCitiesListWindowMethod();
                }
                );
            }
        }

        //Addresses
        private RelayCommand openAddNewAddressWnd;
        public RelayCommand OpenAddNewAddressWnd
        {
            get
            {
                return openAddNewAddressWnd ?? new RelayCommand(obj =>
                {
                    OpenAddAddressWindowMethod();
                }
                    );
            }
        }

        private RelayCommand openEditAddressWnd;
        public RelayCommand OpenEditAddressWnd
        {
            get
            {
                return openAddNewAddressWnd ?? new RelayCommand(obj =>
                {
                    OpenEditAddressWindowMethod();
                }
                );
            }
        }

        private RelayCommand openAddressesListWnd;
        public RelayCommand OpenAddressesListWnd
        {
            get
            {
                return openAddressesListWnd ?? new RelayCommand(obj =>
                {
                    OpenAddressListWindowMethod();
                }

                );
            }
        }

        //companies

        private RelayCommand openAddNewCompanyWnd;
        public RelayCommand OpenAddNewCompanyWnd
        {
            get
            {
                return openAddNewAddressWnd ?? new RelayCommand(obj =>
                {
                    OpenAddCompanyWindowMethod();
                }
                );
            }
        }

        private RelayCommand openEditCompanyWnd;
        public RelayCommand OpenEditCompanyWnd
        {
            get
            {
                return openEditAddressWnd ?? new RelayCommand(obj =>
                {
                    OpenEditCompanyWindowMethod();
                }
                );
            }
        }

        private RelayCommand openCompaniesListWnd;
        public RelayCommand OpenCompaniesListWnd
        {
            get
            {
                return openCompaniesListWnd ?? new RelayCommand(obj =>
                {
                    OpenCompaniesListWindowMethod();
                }
                );
            }
        }

        //unitTypes
        private RelayCommand openAddNewUnitTypeWnd;
        public RelayCommand OpenAddNewUnitTypeWnd
        {
            get 
            {
                return openAddNewUnitTypeWnd ?? new RelayCommand(obj =>
                {
                    OpenAddUnitTypeWindowMethod();
                }
                );
            }
        }

        private RelayCommand openEditUnitTypeWnd;
        public RelayCommand OpenEditUnitTypeWnd
        {
            get 
            {
                return openEditUnitTypeWnd ?? new RelayCommand(obj =>
                {
                    OpenEditUnitTypeWindowMethod();
                });
            }
        }
        private RelayCommand openUnitTypesListWnd;
        public RelayCommand OpenUnitTypesListWnd
        {
            get
            {
                return openUnitTypesListWnd ?? new RelayCommand(obj =>
                {
                    OpenUnitTypesListWindowMethod();
                }
                );
            }
        }

        //transportModes
        private RelayCommand openAddNewTransportModeWnd;
        public RelayCommand OpenAddNewTransportModeWnd
        {
            get {
                return openAddNewTransportModeWnd ?? new RelayCommand(obj =>
                {
                    OpenAddTransportModeWindowMethod();
                }
                );
                }
        }

        private RelayCommand openEditTransportModeWnd;
        public RelayCommand OpenEditTransportModeWnd
        {
            get
            {
                return openEditTransportModeWnd ?? new RelayCommand(obj =>
                {

                    OpenEditTransportModeWindowMethod();
                }

                );
            }
        }

        private RelayCommand openTransportModesListWnd;
        public RelayCommand OpenTransportModesListWnd
        {
            get
            {
                return openTransportModesListWnd ?? new RelayCommand(obj =>
                {
                    OpenTransportModesListWindowMethod();
                }
                );
            }
        }

        //transportModeUnitTypes
        private RelayCommand openAddNewTransportModeUnitTypeWnd;
        public RelayCommand OpenAddNewTransportModeUnitTypeWnd
        {
            get
            {
                return openAddNewTransportModeUnitTypeWnd ?? new RelayCommand(obj =>
                {
                    OpenAddTransportModeUnitTypeWindowMethod();
                }
                );
            }
        }

        private RelayCommand openEditTransportModeUnitTypeWnd;
        public RelayCommand OpenEditTransportModeUnitTypeWnd
        {
            get
            {
                return openEditTransportModeUnitTypeWnd ?? new RelayCommand(obj =>
                {
                    OpenEditTransportModeUnitTypeWindowMethod();
                }
                );
            }
        }

        private RelayCommand openTransportModesUnitTypesListWnd;
        public RelayCommand OpenTransportModesUnitTypesListWnd
        {
            get
            {
                return openTransportModesUnitTypesListWnd ?? new RelayCommand(obj =>
                {
                    OpenTransportModesUnitTypesListWindowMethod();
                }
                );
            }
        }

        //Cargoes
        private RelayCommand openAddNewCargoWnd;
        public RelayCommand OpenAddNewCargoWnd
        {
            get
            {
                return openAddNewCargoWnd ?? new RelayCommand(obj =>
                {
                    OpenAddNewCargoWindowMethod();
                }
                );
            }
        }

        private RelayCommand openEditCargoWnd;
        public RelayCommand OpenEditCargoWnd
        {
            get
            {
                return openAddNewCargoWnd ?? new RelayCommand(obj =>
                {
                    OpenEditCargoWindowMethod();
                }
                );
            }
        }

        private RelayCommand openCargoesListWnd;
        public RelayCommand OpenCargoesListWnd
        {
            get
            {
                return openCargoesListWnd ?? new RelayCommand(obj =>
                {
                    OpenCargoesListWindowMethod();
                }
                );
            }
        }

        //RoutePoints
        private RelayCommand openAddNewRoutePointWnd;
        public RelayCommand OpenAddNewRoutePointWnd
        {
            get
            {
                return openAddNewRoutePointWnd ?? new RelayCommand(obj =>
                {
                    OpenAddNewRoutePointWindowMethod();
                }
                );
            }
        }

        private RelayCommand openEditRoutePointWnd;
        public RelayCommand OpenEditRoutePointWnd
        {
            get
            {
                return openEditRoutePointWnd ?? new RelayCommand(obj =>
                {
                    OpenEditRoutePointWindowMethod();
                }
                );
            }
        }

        private RelayCommand openRoutePointsListWnd;
        public RelayCommand OpenRoutePointsListWnd
        {
            get
            {
                return openRoutePointsListWnd ?? new RelayCommand(obj =>
                {
                    OpenRoutePointsListWindowMethod();
                }
                );
            }
        }

        #endregion

        #region METHODS TO OPEN WINDOW
        //methods of windows open

        //Countries
        private void OpenAddCountriesWindowMethod()
        {
            SetNullValuesToProperties();
            AddCountryWindow addCountryWindow = new AddCountryWindow();
            addCountryWindow.ShowDialog();
        }
        private void OpenEditCountryWindowMethod() 
        {
            EditCountryWindow editCountryWindow = new EditCountryWindow(SelectedCountry);
            editCountryWindow.ShowDialog();
        }
        private void OpenCountriesListWindowMethod()
        {
            CountriesList countriesList = new CountriesList();
            countriesList.ShowDialog();
        }

        //Cities
        private void OpenAddCitiesWindowMethod()
        {
            SetNullValuesToProperties();
            AddCityWindow addCityWindow = new AddCityWindow();
            addCityWindow.ShowDialog();
        }
        private void OpenEditCityWindowMethod()
        {
            CityCountry = DataWorker.GetCountryById(SelectedCity.CountryId);
            EditCityWindow editCityWindow = new EditCityWindow(SelectedCity);
            editCityWindow.CountriesComboBox.SelectedIndex = AllCountries.FindIndex(c => c.Id == CityCountry.Id);
            editCityWindow.ShowDialog();
        }
        private void OpenCitiesListWindowMethod()
        {
            CitiesList citiesList = new CitiesList();
            citiesList.ShowDialog();
        }

        //Addresses
        private void OpenAddAddressWindowMethod()
        {
            SetNullValuesToProperties();
            AddAddressWindow addAddressWindow = new AddAddressWindow();
            addAddressWindow.ShowDialog();
        }
        private void OpenEditAddressWindowMethod()
        {
            AddressCity = DataWorker.GetCityById(SelectedAddress.CityId);
            EditAddressWindow editAddressWindow = new EditAddressWindow(SelectedAddress);
            editAddressWindow.CitiesComboBox.SelectedIndex = AllCities.FindIndex(c =>c.Id == AddressCity.Id);
            editAddressWindow.ShowDialog();
        }
        private void OpenAddressListWindowMethod()
        {
            AddressesList addressesList = new AddressesList();
            addressesList.ShowDialog();
        }

        //Companies
        private void OpenAddCompanyWindowMethod() 
        {
            SetNullValuesToProperties();
            AddCompanyWindow addCompanyWindow = new AddCompanyWindow();
            addCompanyWindow.ShowDialog();
        }
        private void OpenEditCompanyWindowMethod()
        {
            CompanyAddress = DataWorker.GetAddressById(SelectedCompany.AddressId);
            EditCompanyWindow editCompanyWindow = new EditCompanyWindow(SelectedCompany);
            editCompanyWindow.AddressComboBox.SelectedIndex = AllAddresses.FindIndex(a => a.Id == CompanyAddress.Id);
            Company_Type = SelectedCompany.companyType;
            editCompanyWindow.CompanyTypeComboBox.SelectedIndex = AllCompanyTypes.FindIndex(a => a.Equals(Company_Type.ToString()));
            editCompanyWindow.ShowDialog();
        }
        private void OpenCompaniesListWindowMethod()
        {
            CompaniesList companiesList = new CompaniesList();
            companiesList.ShowDialog();
        }

        //UnitTypes
        private void OpenAddUnitTypeWindowMethod()
        {
            SetNullValuesToProperties();
            AddUnitTypeWindow addUnitTypeWindow = new AddUnitTypeWindow();
            addUnitTypeWindow.ShowDialog();
        }
        private void OpenEditUnitTypeWindowMethod()
        {
            EditUnitTypeWindow editUnitTypeWindow = new EditUnitTypeWindow(SelectedUnitType);
            editUnitTypeWindow.ShowDialog();
        }
        private void OpenUnitTypesListWindowMethod()
        {
            UnitTypesListWindow unitTypesListWindow = new UnitTypesListWindow();
            unitTypesListWindow.ShowDialog();
        }

        //TransportModes
        private void OpenAddTransportModeWindowMethod()
        {
            SetNullValuesToProperties();
            AddTransportModeWindow addTransportModeWindow = new AddTransportModeWindow();
            addTransportModeWindow.ShowDialog();
        }
        private void OpenEditTransportModeWindowMethod()
        {     
            EditTransportModeWindow editTransportModeWindow = new EditTransportModeWindow(SelectedTransportMode);
            editTransportModeWindow.ShowDialog();
        }
        private void OpenTransportModesListWindowMethod()
        {
            TransportModesListWindow transportModesListWindow = new TransportModesListWindow();
            transportModesListWindow.ShowDialog();
        }

        //TransportModesUnitTypes
        private void OpenAddTransportModeUnitTypeWindowMethod()
        {
            SetNullValuesToProperties();
            AddTransportModeUnitTypeWindow addTransportModeUnitTypeWindow = new AddTransportModeUnitTypeWindow();
            addTransportModeUnitTypeWindow.ShowDialog();
        }
        private void OpenEditTransportModeUnitTypeWindowMethod()
        {
            TMUTMode = DataWorker.GetTransportModeById(SelectedTMUT.TransportModeId);
            TMUTType = DataWorker.GetUnitTypeById(SelectedTMUT.UnitTypeId);
            EditTransportModeUnitTypeWindow editTransportModeUnitTypeWindow = new EditTransportModeUnitTypeWindow(SelectedTMUT);
            editTransportModeUnitTypeWindow.TransportModesComboBox.SelectedIndex = AllTransportModes.FindIndex(tm => tm.Id == TMUTMode.Id);
            editTransportModeUnitTypeWindow.UnitTypesComboBox.SelectedIndex = AllUnitTypes.FindIndex(tm => tm.Id == TMUTType.Id);
            editTransportModeUnitTypeWindow.ShowDialog();
        }
        private void OpenTransportModesUnitTypesListWindowMethod()
        {
            TransportModesUnitTypesListWindow transportModesUnitTypesListWindow = new TransportModesUnitTypesListWindow();
            transportModesUnitTypesListWindow.ShowDialog();
        }
        //Cargoes
        private void OpenAddNewCargoWindowMethod()
        {
            SetNullValuesToProperties();
            AddCargoWindow addCargoWindow = new AddCargoWindow();
            addCargoWindow.ShowDialog();
        }
        private void OpenEditCargoWindowMethod()
        {
            EditCargoWindow editCargoWindow = new EditCargoWindow(SelectedCargo);
            editCargoWindow.ShowDialog();
        }
        private void OpenCargoesListWindowMethod()
        {
            CargoesList cargoesList = new CargoesList();
            cargoesList.ShowDialog();
        }

        //RoutePoints
        private void OpenAddNewRoutePointWindowMethod()
        { 
            SetNullValuesToProperties();
            AddRoutePointWindow addRoutePointWindow = new AddRoutePointWindow();
            addRoutePointWindow.ShowDialog();
        }

        private void OpenEditRoutePointWindowMethod()
        {
            RoutePointCompany = DataWorker.GetCompanyById(SelectedRoutePoint.CompanyId);
            EditRoutePointWindow editRoutePointWindow = new EditRoutePointWindow(SelectedRoutePoint);
            editRoutePointWindow.RoutePointCompanyComboBox.SelectedIndex = AllRoutePoints.FindIndex(rp => rp.CompanyId.Equals(RoutePointCompany.Id));
            editRoutePointWindow.ShowDialog();
        }

        private void OpenRoutePointsListWindowMethod()
        {
            RoutePointsList routePointsList = new RoutePointsList();
            routePointsList.ShowDialog();               
        }

        private void SetCenterPositionAndOpen(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        #endregion

        #region COMMAND TO DELETE
        //Countries
        private RelayCommand deleteCountry;
        public RelayCommand DeleteCountry
        {
            get 
            { 
                return deleteCountry ?? new RelayCommand(obj =>
                {
                    string resultStr = "Nothing selected!";

                    //delete Country

                    if (SelectedCountry != null)
                    {

                        resultStr = DataWorker.DeleteCountry(SelectedCountry);
                        UpdateCountriesView();
                    }

                    //update
                    SetNullValuesToProperties();
                    ShowMessageToUser(resultStr);
                }
                ); 
            }
        }

        //Cities
        private RelayCommand deleteCity;
        public RelayCommand DeleteCity
        {
            get
            {
                return deleteCity ?? new RelayCommand(obj =>
                {
                    string resultStr = "No city selected!";

                    if ( SelectedCity != null )
                    {
                        resultStr = DataWorker.DeleteCity(SelectedCity);
                        UpdateCitiesView();
                        ShowMessageToUser(resultStr);
                        SetNullValuesToProperties();
                    }

                });
            }
        }

        //Addresses
        private RelayCommand deleteAddress;
        public RelayCommand DeleteAddress
        {
            get
            {
                return deleteAddress ?? new RelayCommand(obj =>
                {
                    string resultStr = "No address is selected!";

                    if ( SelectedAddress != null )
                    {
                        resultStr = DataWorker.DeleteAddress(SelectedAddress);
                        ShowMessageToUser(resultStr);
                        UpdateAddressesView();
                        SetNullValuesToProperties();
                    }
                });
            }
        }

        //Companies
        private RelayCommand deleteCompany;
        public RelayCommand DeleteCompany
        {
            get
            {
                return deleteCompany ?? new RelayCommand(obj => 
                {
                    string resultStr = "No Company is selected!";

                    if ( SelectedCompany != null )
                    {
                        resultStr += DataWorker.DeleteCompany(SelectedCompany);
                        ShowMessageToUser(resultStr);
                        UpdateCompaniesView();
                        SetNullValuesToProperties();
                    }


                }
                );
            }
        }

        //UnitTypes
        private RelayCommand deleteUnitType;
        public RelayCommand DeleteUnitType
        {
            get
            {
                return deleteUnitType ?? new RelayCommand(obj =>
                {
                    string resultStr = "No Unit type is selected!";

                    if (SelectedUnitType != null )
                    {
                        resultStr = DataWorker.DeleteUnitType(SelectedUnitType);
                        ShowMessageToUser(resultStr);
                        UpdateUnitTypesView();
                        SetNullValuesToProperties();
                    }
                }
                );
            }
        }

        //TransportModes
        private RelayCommand deleteTransportMode;
        public RelayCommand DeleteTransportMode
        {
            get
            {
                return deleteTransportMode ?? new RelayCommand(obj =>
                {
                    string resultStr = "No TransportMode is selected";

                    if ( SelectedTransportMode != null )
                    {
                        resultStr = DataWorker.DeleteTransportMode(SelectedTransportMode);

                        UpdateTransportModesView();
                        SetNullValuesToProperties();
                    }
                    ShowMessageToUser(resultStr);
                }

                );
            }
        }

        //TransportModesUnitTypes
        private RelayCommand deleteTransportModeUnitType;
        public RelayCommand DeleteTransportModeUnitType
        {
            get
            {
                return deleteTransportModeUnitType ?? new RelayCommand(obj =>
                {
                    string resultStr = "No TransportModeUnitType is selected";

                    if (SelectedTMUT  != null ) 
                    { 
                        resultStr = DataWorker.DeleteTransportModeUnitType(SelectedTMUT);
                        SetNullValuesToProperties();
                        UpdateTMUTView();
                    }

                    ShowMessageToUser(resultStr);
                }
                );
            }
        }

        //Cargo
        private RelayCommand deleteCargo;
        public RelayCommand DeleteCargo
        {
            get
            {
                return deleteCargo ?? new RelayCommand(obj =>
                {
                    string resultStr = "No Cargo is selected!";

                    if ( SelectedCargo != null )
                    {
                        resultStr = DataWorker.DeleteCargo(SelectedCargo);
                        UpdateCargoesView();
                        SetNullValuesToProperties();                       
                    }
                    ShowMessageToUser(resultStr);
                });
            }
        }

        #endregion

        #region COMMANDS TO EDIT

        //Countries
        private RelayCommand editCountry;
        public RelayCommand EditCountry
        {
            get
            {
                return editCountry ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "No country is selected!";

                    if ( CountryId != 0 )
                    {
                        Country editedCountry = DataWorker.GetCountryById(CountryId);
                        resultStr = DataWorker.EditCountry(editedCountry, CountryNameENG, CountryNameUKR);
                        UpdateCountriesView();
                        SetNullValuesToProperties();
                    }
                    ShowMessageToUser(resultStr);
                    window.Close();

                });
            }
        }

        //Cities
        private RelayCommand editCity;
        public RelayCommand EditCity
        {
            get
            {
                return editCity ?? new RelayCommand(obj =>
                {
                    Window window= obj as Window;
                    string resultStr = "No city is selected!";

                    if ( CityId != 0 )
                    {
                        resultStr = DataWorker.EditCity(SelectedCity, CityNameENG, CityNameUKR, CityCountry);
                        UpdateCitiesView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                    ShowMessageToUser(resultStr);

                }
                );
            }
        }

        //Addresses
        private RelayCommand editAddress;
        public RelayCommand EditAddress
        {
            get
            {
                return editAddress ?? new RelayCommand(obj =>
                {
                    Window window= obj as Window;
                    string resultStr = "No address is selected!";

                    if ( AddressId != 0 )
                    {
                        resultStr = DataWorker.EditAddress(SelectedAddress, AddressNameENG, AddressNameUKR, AddressCity);
                        UpdateAddressesView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                    ShowMessageToUser(resultStr);

                });
            }
        }

        //Companies
        private RelayCommand editCompany;
        public RelayCommand EditCompany
        {
            get
            {
                return editCompany ?? new RelayCommand(obj => 
                {
                    Window window= obj as Window;
                    string resultStr = "No company is selected";

                    if ( SelectedCompany != null )
                    {
                        resultStr = DataWorker.EditCompany(SelectedCompany, CompanyNameENG, CompanyNameUKR, Company_Type, CompanyAddress);
                        UpdateCompaniesView();
                        SetNullValuesToProperties();
                        window.Close();
                    }
                    ShowMessageToUser(resultStr);
                }
                );
            }
        }

        //UnitTypes
        private RelayCommand editUnitType;
        public RelayCommand EditUnitType
        {
            get
            {
                return editUnitType ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "No Unit type is selected!";

                    if (SelectedUnitType != null )
                    {
                        resultStr = DataWorker.EditUnitType(SelectedUnitType, UnitTypeNameENG, UnitTypeNameUKR, UnitTypeMaxGW);
                        UpdateUnitTypesView();
                        SetNullValuesToProperties();
                        window.Close ();
                    }
                    ShowMessageToUser(resultStr);
                });
            }
        }

        //TransportModes
        private RelayCommand editTransportMode; 
        public RelayCommand EditTransportMode
        {
            get
            {
                return editTransportMode ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "No TransportMode is selected!";

                    if (SelectedTransportMode != null )
                    {
                        resultStr = DataWorker.EditTransportMode(SelectedTransportMode, TransportModeNameENG, TransportModeNameUKR);
                        UpdateTransportModesView();
                        SetNullValuesToProperties();
                        window.Close ();
                    }
                    ShowMessageToUser (resultStr);
                });
            }
        }

        //TransportModesUnitTypes
        private RelayCommand editTransportModeUnitType;
        public RelayCommand EditTransportModeUnitType
        {
            get
            {
                return editTransportModeUnitType ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "No TransportModeUnitType is selected!";

                    if (TMUTMode == null)
                    {
                        ShowMessageToUser("Please choose TransportMode");
                    }
                    if (TMUTType == null)
                    {
                        ShowMessageToUser("Please choose UnitType");
                    }
                    else
                    {
                        resultStr = DataWorker.EditTransportModeUnitType(SelectedTMUT, TMUTMode, TMUTType);
                        UpdateTMUTView();   
                        SetNullValuesToProperties();
                        window.Close();
                    }
                    ShowMessageToUser(resultStr);
                }
                );
            }
        }

        //Cargoes
        private RelayCommand editCargo;
        public RelayCommand EditCargo
        {
            get
            {
                return editCargo ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "No Cargo is selected!";

                    if (SelectedCargo != null )
                    {
                        resultStr = DataWorker.EditCargo(SelectedCargo, CargoNameENG, CargoNameUKR, CargoCode);
                        UpdateCargoesView();
                        SetNullValuesToProperties();                       
                        window.Close ();
                    }
                    ShowMessageToUser(resultStr);
                });
            }
        }

        #endregion

        #region COMMAND TO CLOSE WINDOWS

        private RelayCommand closeWnd;
        public RelayCommand CloseWnd
        {
            get
            {
                return closeWnd ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    
                    //ShowMessageToUser(window.GetType().FullName + " " +
                    //    window.Name);

                    if (window.Name == "CountriesListWnd") 
                    {
                        UpdateCountriesInAddNewCityWnd();
                    }
                    if(window.Name == "CitiesListWnd") 
                    {
                        UpdateCitiesInAddAddressWnd();
                    }
                    if (window.Name == "AddressesListWnd")
                    {
                        UpdateAddressesInAddCompaniesWnd();
                    }

                    window.Close();
                }
                );
            }
        }

        #endregion

        #region UPDATE VIEWS


        private void UpdateCountriesView()
        {
            AllCountries = DataWorker.GetAllCountries();
            CountriesList.AllCountriesView.ItemsSource = null;
            CountriesList.AllCountriesView.Items.Clear();
            CountriesList.AllCountriesView.ItemsSource = AllCountries;
            CountriesList.AllCountriesView.Items.Refresh();
        }
        private void UpdateCitiesView()
        {
            AllCities = DataWorker.GetAllCities();
            CitiesList.AllCitiesView.ItemsSource = null;
            CitiesList.AllCitiesView.Items.Clear();
            CitiesList.AllCitiesView.ItemsSource = AllCities;
            CitiesList.AllCitiesView.Items.Refresh();
        }
        private void UpdateAddressesView()
        {
            AllAddresses = DataWorker.GetAlAddresses();
            AddressesList.AllAddressesView.ItemsSource = null;
            AddressesList.AllAddressesView.Items.Clear();
            AddressesList.AllAddressesView.ItemsSource = AllAddresses;
            AddressesList.AllAddressesView.Items.Refresh();
            
        }
        private void UpdateCompaniesView()
        {
            AllCompanies = DataWorker.GetAllCompanies();
            CompaniesList.AllCompaniesView.ItemsSource = null;
            CompaniesList.AllCompaniesView.Items.Clear();
            CompaniesList.AllCompaniesView.ItemsSource = AllCompanies;
            CompaniesList.AllCompaniesView.Items.Refresh();
        }
        private void UpdateUnitTypesView()
        {
            AllUnitTypes = DataWorker.GetAllUnitTypes();
            UnitTypesListWindow.AllUnitTypesList.ItemsSource = null;
            UnitTypesListWindow.AllUnitTypesList.Items.Clear();
            UnitTypesListWindow.AllUnitTypesList.ItemsSource = AllUnitTypes;
            UnitTypesListWindow.AllUnitTypesList.Items.Refresh();
        }
        private void UpdateTransportModesView()
        {
            AllTransportModes = DataWorker.GetAllTransportModes();
            TransportModesListWindow.AllTransportModesList.ItemsSource = null;
            TransportModesListWindow.AllTransportModesList.Items.Clear();
            TransportModesListWindow.AllTransportModesList.ItemsSource = AllTransportModes;
            TransportModesListWindow.AllTransportModesList.Items.Refresh();
        }
        private void UpdateTMUTView()
        {
            AllTransportModesUnitTypes = DataWorker.GetAllTransportModeUnitTypes();
            TransportModesUnitTypesListWindow.AllTransportModeUnitTypesView.ItemsSource = null;
            TransportModesUnitTypesListWindow.AllTransportModeUnitTypesView.Items.Clear();
            TransportModesUnitTypesListWindow.AllTransportModeUnitTypesView.ItemsSource = AllTransportModesUnitTypes;
            TransportModesUnitTypesListWindow.AllTransportModeUnitTypesView.Items.Refresh();

        }
        private void UpdateCargoesView()
        {
            AllCargoes = DataWorker.GetAllCargoes();
            CargoesList.AllCagoesList.ItemsSource = null;
            CargoesList.AllCagoesList.Items.Clear();
            CargoesList.AllCagoesList.ItemsSource = AllCargoes;
            CargoesList.AllCagoesList.Items.Refresh();
        }
        private void UpdateRoutePointsView()
        {
            AllRoutePoints = DataWorker.GetAllRoutePoints();
            RoutePointsList.AllRoutePointsView.ItemsSource = null;
            RoutePointsList.AllRoutePointsView.Items.Clear();
            RoutePointsList.AllRoutePointsView.ItemsSource = AllRoutePoints;
            RoutePointsList.AllRoutePointsView.Items.Refresh();
        }
        private void UpdateCountriesInAddNewCityWnd()
        {
            AllCountries = DataWorker.GetAllCountries();
            AddCityWindow.NewCountriesComboBox.ItemsSource = null;
            AddCityWindow.NewCountriesComboBox.Items.Clear();
            AddCityWindow.NewCountriesComboBox.ItemsSource = allCountries;
            AddCityWindow.NewCountriesComboBox.Items.Refresh();
        }
        private void UpdateCitiesInAddAddressWnd()
        {
            AllCities = DataWorker.GetAllCities();
            AddAddressWindow.NewCitiesSource.ItemsSource = null;
            AddAddressWindow.NewCitiesSource.Items.Clear();
            AddAddressWindow.NewCitiesSource.ItemsSource = AllCities;
            AddAddressWindow.NewCitiesSource.Items.Refresh();
        }
        private void UpdateAddressesInAddCompaniesWnd()
        {
            AllAddresses = DataWorker.GetAlAddresses();
            AddCompanyWindow.NewAddressesItemSource.ItemsSource = null;
            AddCompanyWindow.NewAddressesItemSource.Items.Clear();
            AddCompanyWindow.NewAddressesItemSource.ItemsSource= AllAddresses;
            AddCompanyWindow.NewAddressesItemSource.Items.Refresh();
        }

        #endregion

        private void SetNullValuesToProperties()
        {
            //country
            CountryId = 0;
            CountryNameENG = null;
            CountryNameUKR = null;

            //city
            CityId = 0;
            CityNameENG = null;
            CityNameUKR = null;
            CityCountry = null;

            //address
            AddressId = 0;
            AddressNameENG = null;
            AddressNameUKR = null;
            AddressCity = null;

            //company
            CompanyId = 0;
            CompanyNameENG = null;
            CompanyNameUKR = null;
            CompanyAddress = null;

            //unitType
            UnitTypeId = 0;
            UnitTypeNameENG = null;
            UnitTypeNameUKR = null;
            UnitTypeMaxGW = 0;

            //transportModes
            TransportModeId = 0;
            TransportModeNameENG = null;
            TransportModeNameUKR = null;

            //transportModesUnitTypes
            TransportModeUnitTypeId = 0;
            TMUTMode = null;
            TMUTType = null;

            //Cargo
            CargoId = 0;
            CargoNameENG = null;
            CargoNameUKR = null;
            CargoCode = null;

            //RoutePoint
            RoutePointId = 0;
            RoutePointCompany = null;
            RoutePointTransportModes = null;
            RoutePointUnitTypes = null;

        }
        private void SetRedBlockControl(Window window, string blockName)
        {
            Control control = window.FindName(blockName) as Control;
            control.BorderBrush = Brushes.Red;
        }

        private void ShowMessageToUser(string message)
        {
            MessageView messageView = new MessageView(message);
            messageView.ShowDialog();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
      
    }
}
