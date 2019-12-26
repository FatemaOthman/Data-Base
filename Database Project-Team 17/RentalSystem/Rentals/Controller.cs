using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Rentals
{
    public class Controller
    {
        DatabaseManager dbMan;

        public Controller()
        {
            dbMan = new DatabaseManager();
        }

//-----------------------------------User Table Related Functions-----------------------------------------------

                  //This Function Establishes the Sign in connection so that no UnAuthorized access is allowed
        public int SignIn(string username, int password)
        {
           
           string  query = "SELECT User_Name FROM Users WHERE User_Name = '" + username + "'And User_Password = "+ password+";";
            string un = (string)dbMan.ExecuteScalar(query);
            query = "SELECT User_Password FROM Users WHERE User_Name = '" + username + "'And User_Password = " + password + ";";
            int pw = 0;
            if (un != null)
            {
                 pw = (int)dbMan.ExecuteScalar(query);
            }
            if (un == null && pw == 0)
            {
                return 0;
            }
            else if (un != "" && pw != 0)
                return 1;
            else
                return 2;
        }
                                          //Updates User
        public int UpdateUser(int oldpass, int newpass,int UT,string Username,string NewUsername )
        {
            string query = "UPDATE Users SET User_Password="+newpass+ ",User_Priv="+UT+",User_Name = '"+NewUsername+"' WHERE User_Password = " + oldpass + "AND User_Name = '" +Username +"';";
            return dbMan.ExecuteNonQuery(query);
        }


        public int UpdateUser1(int oldpass, int newpass, string Username, string NewUsername)
        {
            string query = "UPDATE Users SET User_Password=" + newpass +  ",User_Name = '" + NewUsername + "' WHERE User_Password = " + oldpass + "AND User_Name = '" + Username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        //Gets The User Priviliage from his Username
        public int GetUserPriv(string username)
        {
            string query = "SELECT User_Priv FROM Users WHERE User_name = '" + username + "'";
            return (int)dbMan.ExecuteScalar(query);
        }
                                        //Create a user with priv = 1 always
        public int CreateAdmin(string username, string password)
        {
            string query = "INSERT INTO Users(User_Name, User_Password, User_Priv) VALUES('" + username + "','" + password + "'," + "1)";
            return dbMan.ExecuteNonQuery(query);
        }
                                         //creates a user
        public int CreateUser(string username, string password, int priv)
        {
            string query = "INSERT INTO Users(User_Name, User_Password, User_Priv) VALUES('" + username + "','" + password + "'," + priv + ")";
            return dbMan.ExecuteNonQuery(query);
        }
                                          //Ensures that  the selected user and his ccredintals are for the admin
        public int GetAdminApproval(string password)
        {
            string query = "Select User_Password FROM Users WHERE User_Password = '" + password + "' AND User_Priv = 1";
            return dbMan.ExecuteNonQuery(query);
        }

//-----------------------------------Rent Table Related Functions-----------------------------------------------
                                     //pays Unpays a rent
        public int PayRent(int Pay,int ID)
        {
            string query = "UPDATE Rents SET Rent_Statues =" + Pay + " WHERE Rent_Id = " + ID+ ";";
            return dbMan.ExecuteNonQuery(query);
        }
                                     //returns Rents by the Statue
        public DataTable GetRentsByStat(string Stat)
        {
            string query;
            query = "SELECT * FROM Rents,Unit_Rents  FULL JOIN Units ON  Unit_Rents_UnitId = Unit_Id WHERE  Unit_Rents_RentId = Rent_Id AND  (Rent_Statues = " + Stat + "ORDER BY Rent_Id";
            return dbMan.ExecuteReader(query);
        }
                                     //Change the Collector for a certain rent
        public int ChangeCollecter(int ID, int RID)
        {
            string query = "UPDATE Rents SET Rent_CollecterId =" + ID + " WHERE Rent_Id = " + RID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        
//-----------------------------------Employee Table Related Functions-----------------------------------------------
                                    //Get a Certain Employee by his ID
        public string GetEmpById(string ID)
        {
            string query = "SELECT Employee_FirstName FROM Employees WHERE Employee_Id = " + ID + "";
            return (string)dbMan.ExecuteScalar(query);
        }
                                    //Get All Collecter Type Employees
        public DataTable GetAllCollecters()
        {
            string query = "SELECT * FROM Employees WHERE Employee_Type = 'Cash Collecter'";
            return (DataTable)dbMan.ExecuteReader(query);
        }
     
//-----------------------------------Units Table Related Functions-----------------------------------------------
                                      //Get all Units
        public DataTable GetAllUnits()
        {
            string query = "SELECT * FROM Units";
            return (DataTable)dbMan.ExecuteReader(query);
        }

        public string GetUnitById(string ID)
        {
            string query = "SELECT Unit_Id FROM Units WHERE Unit_Id = " + ID + "";
            return (string)dbMan.ExecuteScalar(query).ToString();
        }

        public DataTable GetUnitsByBuildingId(int bid)
        {
            string query = "SELECT * FROM Units WHERE Unit_BuildingNo = " +bid+ "AND Unit_State = 0 ";
            return (DataTable)dbMan.ExecuteReader(query);
        }

        //-----------------------------------Tenants Table Related Functions-----------------------------------------------
        //Get all Tenants
        public DataTable GetAllTenants()
        {
            string query = "SELECT * FROM Tenants";
            return (DataTable)dbMan.ExecuteReader(query);
        }

        public string GetTenantById(string ID)
        {
            string query = "SELECT Tenant_FirstName FROM Tenants WHERE Tenant_Id = " + ID + "";
            return (string)dbMan.ExecuteScalar(query);
        }

        //-----------------------------------Building Relatd Functions----------------------------------------------
        public DataTable GetAllBuildings()
        {
            string query = "SELECT * FROM Buildings";
            return (DataTable)dbMan.ExecuteReader(query);
        }
        public string GetBuildingById(string ID)
        {
            string query = "SELECT Building_Name FROM Buildings WHERE Building_Id = " + ID + "";
            return (string)dbMan.ExecuteScalar(query);
        }

        //-----------------------------------Owners fucntions-------------------------------------------------------



        //pays Unpays a rent
        public int PayRentToOwner(int Rent, int OID)
        {
            string query = "UPDATE Owners SET Owner_Income = Owner_Income +" + Rent + " WHERE Owner_Id = " + OID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UnPayRentToOwner(int Rent, int OID)
        {
            string query = "UPDATE Owners SET Owner_Income = Owner_Income -" + Rent + " WHERE Owner_Id = " + OID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetOwnerFirstName()
        {
            string query = "SELECT Owner_FirstName FROM Owners";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetOwnerInfo(string ID)
        {
            string query = "SELECT * FROM Owners WHERE Owner_Id = '" + ID + "';";
            return dbMan.ExecuteReader(query);
        }

        public int AddOwner(int SSN, string FirstName, string LastName, string PhoneNumber, string Address, int NoOfBuildings, int Income)
        {
            string query = "INSERT INTO Owners (Owner_SSN, Owner_FirstName, Owner_LastName, Owner_PhoneNumber, Owner_Address, Owner_NumberOfBuildingsOwned, Owner_Income) VALUES(" + SSN + ",'" + FirstName + "','" + LastName + "','" + PhoneNumber + "','" + Address + "'," + NoOfBuildings + "," + Income + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetAllOwnerInfo()
        {
            string query = "SELECT * FROM Owners";
            return dbMan.ExecuteReader(query);
        }


        public int UpdateOwnerByID(int ID, string FirstName, string LastName, string PhoneNumber, string Address, int NoOfBuildings, int Income)
        {
            string query = "UPDATE Owners SET Owner_FirstName = '" + FirstName + "', Owner_LastName = '" + LastName + "', Owner_PhoneNumber = '" + PhoneNumber + "', Owner_Address = '" + Address + "', Owner_NumberOfBuildingsOwned = " + NoOfBuildings + ", Owner_Income = " + Income + " WHERE Owner_ID= " + ID;
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteOwner(int ID)
        {
            string query = "DELETE FROM Owners WHERE Owner_Id = " + ID;
            return dbMan.ExecuteNonQuery(query);
        }

        //-----------------------------------Contacts-----------------------------------------------------


        public DataTable GetAllContacts()
        {
            string query = "SELECT * FROM Contacts";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetContactByID(int ID)
        {
            string query = "SELECT * FROM Contacts WHERE Contact_ID = " + ID;
            return dbMan.ExecuteReader(query);
        }

        public int DeleteContactbyID(int ID)
        {
            string query = "DELETE FROM Contacts WHERE Contact_ID = " + ID;
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddContact(string FirstName, string LastName, int PhoneNumber, string Email, string Address, string status)
        {
            string query = "INSERT INTO Contacts(Contact_FirstName, Contact_LastName, Contact_PhoneNumber, Contact_Email, Contact_Adrress, Contact_Status) VALUES('" + FirstName + "','" + LastName + "'," + PhoneNumber + ",'" + Email + "','" + Address + "','" + status + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateContactByID(int ID, string FirstName, string LastName, int PhoneNumber, string Email, string Address, string status)
        {
            string query = "UPDATE Contacts SET Contact_FirstName = '" + FirstName + "', Contact_LastName = '" + LastName + "', Contact_PhoneNumber = " + PhoneNumber + ", Contact_Email = '" + Email + "', Contact_Adrress = '" + Address + "', Contact_Status = '" + status + "' WHERE Contact_ID = " + ID;
            return dbMan.ExecuteNonQuery(query);
        }




        //-----------------------------------Leases Function--------------------------------------------

        public int TakeExpenseFromDeposit(int expense,int LID)
        {
            string query = "UPDATE Leases SET Lease_Deposit = Lease_Deposit - " + expense+ " WHERE Lease_Id = " + LID + ";";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable GetAllLeases()
        {
            string query = "SELECT * FROM Leases";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLeasesById(string lid)
        {
            string query = "SELECT * FROM Leases WHERE Lease_Id = "+lid;
            return dbMan.ExecuteReader(query);
        }

        public int AddLease(DateTime LED, DateTime LSD, string stat,decimal ra,int LI,int INTI,decimal LD,DateTime LND,int TID)
        {
            string query = " INSERT INTO Leases(Lease_EndDate, Lease_StartDate, Lease_Status, Lease_RentAmount, Lease_Interest, Lease_InterestInterval, Lease_Deposit, Lease_NextInterestDate, Lease_TenantId) VALUES('" + LED.ToString("yyyy-MM-dd") + "','" + LSD.ToString("yyyy-MM-dd") + "'," + stat + "," + ra +","+ LI + ", " +INTI +","+LD+ " , '"+ LND.ToString("yyyy-MM-dd") +"',"+ TID+ ")";
            return dbMan.ExecuteNonQuery(query);
        }

        public int GetLeaseID()
        {
            string query = "SELECT IDENT_CURRENT('Leases') AS Current_Identity";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
    
        public int GetRentID()
        {
            string query = "SELECT IDENT_CURRENT('Rents') AS Current_Identity";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int AddUnit_Rent(int tenantid, int unitid, int rentid)
        {
            string query = "INSERT INTO Unit_Rents VALUES(" + tenantid + "," + unitid + "," + rentid + ")";
            return dbMan.ExecuteNonQuery(query);
        }


        //  public DataTable GetLeaseTenant(string Lid)
        //  {
        //string query = "SELECT * FROM Rents,Unit_Rents_UnitId FULL JOIN Units ON  Unit_Rents_UnitId WHERE Lease_Id = "+Lid ;
        //return dbMan.ExecuteReader(query);
        // }


        //-----------------------------------Expenses---------------------------------------------------
        public int AddExpense(int ownerid, int amount, DateTime date, string reason, int leaseid)
        {
            string query = "INSERT INTO EXPENSES(Expense_Amount, Expense_Date, Expense_Reason, Expense_LeaseId, Expense_OwnerId) VALUES(" + amount + ",'" + date.ToString("yyyy-MM-dd") + "','" + reason + "'," + leaseid + ", " + ownerid + ')';
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddExpense1(int ownerid, int amount, DateTime date, string reason)
        {
            string query = "INSERT INTO EXPENSES(Expense_Amount, Expense_Date, Expense_Reason, Expense_OwnerId) VALUES(" + amount + ",'" + date.ToString("yyyy-MM-dd") + "','" + reason + "'," + ownerid + ')';
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetAllOwners()
        {
            string query = "SELECT Owner_ID FROM Owners";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllLeasesID()
        {
            string query = "SELECT Lease_ID FROM Leases";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteExpense(int expenseid)
        {
            string query = "DELETE FROM Expenses WHERE Expense_TranID = " + expenseid;
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateExpense(int expenseid, int ownerid, int amount, DateTime date, string reason, int leaseid)
        {
            string query = "UPDATE Expenses SET Expense_OwnerId = " + ownerid + ", Expense_Amount = " + amount + ", Expense_Date = '" + date.ToString("yyyy-MM-dd") + "', Expense_Reason = '" + reason + "', Expense_LeaseId = " + leaseid + " WHERE Expense_TranID = " + expenseid;
            return dbMan.ExecuteNonQuery(query);
        }

        public int TakeExpenseFromOwner(int expense, int OID)
        {
            string query = "UPDATE Owners SET Owner_Income = Owner_Income - " + expense + " WHERE Owner_Id = " + OID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateExpense1(int expenseid, int ownerid, int amount, DateTime date, string reason)
        {
            string query = "UPDATE Expenses SET Expense_OwnerId = " + ownerid + ", Expense_Amount = " + amount + ", Expense_Date = '" + date.ToString("yyyy-MM-dd") + "', Expense_Reason = '" + reason + "' WHERE Expense_TranID = " + expenseid;
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetAllExpenses()
        {
            string query = "SELECT Expense_TranID FROM Expenses";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ShowAllExpenses()
        {
            string query = "SELECT * FROM EXPENSES";
            return dbMan.ExecuteReader(query);
        }
        //-----------------------------------Accounting------------------------------------------------
        public double GetOwnerIncome(int id)
        {
            string query = "SELECT Owner_Income FROM Owners WHERE Owner_ID = " + id;
            return Convert.ToDouble(dbMan.ExecuteScalar(query));
        }

        public double GetOwnerExpenses(int id)
        {
            string query = "SELECT SUM(Expense_Amount) FROM Expenses WHERE Expense_OwnerId = " + id;
            return Convert.ToDouble(dbMan.ExecuteScalar(query));
        }

        public double GetSumIncome()
        {
            string query = "SELECT SUM(Owner_Income) FROM Owners";
            return Convert.ToDouble(dbMan.ExecuteScalar(query));
        }

        public double GetSumExpenses()
        {
            string query = "SELECT SUM(Expense_Amount) FROM Expenses";
            return Convert.ToDouble(dbMan.ExecuteScalar(query));
        }






        //------------------------------------Rents-----------------------------------------------------
      
        public int AddRent(double ra,DateTime DD, string stat,int RC, int leaseid)
        {
            string query = "INSERT INTO Rents(Rent_Amount, Rent_DueDate, Rent_Statues, Rent_CollecterId, Rent_LeasesId) VALUES(" + ra + ",'" + DD.ToString("yyyy-MM-dd") + "'," + stat + "," + RC + "," + leaseid + ")";
            return dbMan.ExecuteNonQuery(query);
        }



        //-----------------------------------User Table Related Functions-----------------------------------------------

       

        //-----------------------------------Tenants Table Related Functions-----------------------------------------------
        //Get all Tenants
        public DataTable GetAllTenants(string text)
        {
            string query = "SELECT * FROM Tenants";
            return (DataTable)dbMan.ExecuteReader(query);
        }

        //-----------------------------------5alas Feneeto----------------------------------------------
        //-----------------------------------Owners fucntions-------------------------------------------------------
        public DataTable GetOwnerLastNames()
        {
            string query = "SELECT Owner_LastName FROM Owners";
            return dbMan.ExecuteReader(query);
        }

   
        public int AddOwner(int SSN, string FirstName, string LastName, int PhoneNumber, string Address, int NoOfBuildings, int Income)
        {
            string query = "INSERT INTO Owners (Owner_SSN, Owner_FirstName, Owner_LastName, Owner_PhoneNumber, Owner_Address, Owner_NumberOfBuildingsOwned, Owner_Income) VALUES(" + SSN + ",'" + FirstName + "','" + LastName + "'," + PhoneNumber + ",'" + Address + "'," + NoOfBuildings + "," + Income + ");";
            return dbMan.ExecuteNonQuery(query);
        }
       

        public int UpdateOwnerBySSN(int SSN, string FirstName, string LastName, int PhoneNumber, string Address, int NoOfBuildings, int Income)
        {
            string query = "UPDATE Owners SET Owner_FirstName = '" + FirstName + "', Owner_LastName = '" + LastName + "', Owner_PhoneNumber = " + PhoneNumber + ", Owner_Address = '" + Address + "', Owner_NumberOfBuildingsOwned = " + NoOfBuildings + ", Owner_Income = " + Income + " WHERE Owner_SSN = " + SSN;
            return dbMan.ExecuteNonQuery(query);
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------Tenants Functions------------------------------------------------------------------------------------------
        public DataTable GetTenantsID()
        {
            string query = "SELECT Tenant_Id FROM Tenants ";
            return dbMan.ExecuteReader(query);
        }

        public int AddTenant(int SSN, string Firstname, string Lastname, int Phonenumber, string buildingNUM, int unitNUM)
        {
            string query = "INSERT INTO Tenants (Tenant_SSN, Tenant_FirstName, Tenant_LastName, Tenant_PhoneNumber) VALUES(" + SSN + ",'" + Firstname + "','" + Lastname + "'," + Phonenumber + ");";
            return dbMan.ExecuteNonQuery(query);
        }


        public int UpdateTenantById(int id, int SSN, string Firstname, string Lastname, int Phonenumber)
        {
            string query = "UPDATE Tenants SET Tenant_SSN=" + SSN + ", Tenant_FirstName = '" + Firstname + "', Tenant_LastName = '" + Lastname + "', Tenant_PhoneNumber = " + Phonenumber + " WHERE Tenant_Id = " + id;
            return dbMan.ExecuteNonQuery(query);

        }

        public DataTable GetAllTenantsInfo()
        {
            string query = "SELECT * FROM Tenants";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetTenant(int Id)
        {
            string query = "SELECT * FROM Tenants WHERE Tenant_ID=" + Id;
            return dbMan.ExecuteReader(query);
        }

        public int DelTenant(int id)
        {

            string query = "DELETE FROM Tenants WHERE Tenant_Id = " + id;
            return dbMan.ExecuteNonQuery(query);

        }

        public DataTable GetTenantContacts()
        {

            string query = "SELECT Contact_Id FROM Contacts ";
            return dbMan.ExecuteReader(query);

        }








        //----------------------------------------------BUILDINGS FUNCTIONS---------------------------------------

        public DataTable GetBuildingsName()
        {
            string query = "SELECT  Building_Name  FROM Buildings ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetBuildingsByName(string nme)
        {
            string query = "SELECT * FROM Buildings WHERE Building_Name='" + nme + "'";
            return dbMan.ExecuteReader(query);
        }

       
        public int AddBuildings(string Bname, string Bstreet, string Bcity, string Bdistrict, int Bnum, int BnumOfUnis, int BOwnerId)
        {
            string query = "INSERT INTO Buildings (Building_Name,Building_Street,Building_City,Building_District,Building_Number,Building_NumberOfUnits,Building_OwnerId) VALUES('" + Bname + "','" + Bstreet + "','" + Bcity + "','" + Bdistrict + "'," + Bnum + "," + BnumOfUnis + "," + BOwnerId + ")";
            return dbMan.ExecuteNonQuery(query);
        }


        public int UpdateBuildingById(int id, string Bname, string Bstreet, string Bcity, string Bdistrict, int Bnum, int BnumOfUnis, int BOwnerId)
        {
            string query = "UPDATE Buildings SET Building_Name = '" + Bname + "', Building_Street = '" + Bstreet + "', Building_City  =  '" + Bcity + "', Building_District  = '" + Bdistrict + "',Building_Number= " + Bnum + " ,Building_NumberOfUnits= " + BnumOfUnis + ", Building_OwnerId=" + BOwnerId + "  WHERE Building_Id = " + id;
            return dbMan.ExecuteNonQuery(query);

        }

        public int DeleteBuilding(int id)
        {
            string query = "DELETE FROM Buildings WHERE Building_Id = " + id;
            return dbMan.ExecuteNonQuery(query);

        }

        //----------------------------------------------UNITS FUNCTIONS---------------------------------------

        public DataTable GetUnitbyID()
        {
            string query = "Select Units.Unit_Id from Units ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetALLUnits()
        {
            string query = "SELECT  *  FROM Units ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowCertianUnit(int id)
        {
            string query = "SELECT  *  FROM Units where  Unit_Id=" + id;
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetUnitsID(String name) //for tenant form 
        {
            string query = "SELECT  Unit_Id  FROM Units u,Buildings b WHERE b.Building_Id=u.Unit_BuildingNo AND b.Building_Name='" + name + "'";
            return dbMan.ExecuteReader(query);
        }


        public object GetUnitsIdFORB(int d) //for tenant form 
        {
            string query = "SELECT  Unit_Id  FROM Units u,Buildings b WHERE b.Building_Id=u.Unit_BuildingNo and u.Unit_BuildingNo=" + d;
            return dbMan.ExecuteScalar(query);
        }

        public int deleteUNITTT(object Uid)
        {
            string query = " DELETE FROM Units WHERE Unit_Id =" + Uid;
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetUnEmployedContactID()
        {
            string query = "SELECT Contact_ID FROM Contacts WHERE Contact_Status != 'Employee';";
            return (DataTable)dbMan.ExecuteReader(query);
        }

        public DataTable GetAllOwnerID()
        {
            string query = "SELECT Owner_Id FROM Owners;";
            return (DataTable)dbMan.ExecuteReader(query);
        }



        public int AddUnits(string Utype, int UReqRent, int Ustate, int Uarea, int UnumOfbathrooms, int Bnumofrooms, string UCond, int UBuildNum)
        {
            string query = "INSERT INTO Units (Unit_Type,Unit_RequiredRent,Unit_State,Unit_Area,Unit_NumberOfBathrooms,Unit_NumberOfRooms,Unit_Condition,Unit_BuildingNo) VALUES('" + Utype + "'," + UReqRent + "," + Ustate + "," + Uarea + "," + UnumOfbathrooms + "," + Bnumofrooms + ",'" + UCond + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateUnit(int Uid, string Utype, int UReqRent, int Ustate, int Uarea, int UnumOfbathrooms, int Bnumofrooms, string UCond, int UBuildNum)
        {
            string query = " UPDATE Units SET Unit_Type= '" + Utype + "', Unit_RequiredRent =" + UReqRent + ",Unit_State= " + Ustate + ",Unit_Area= " + Uarea + ",Unit_NumberOfBathrooms= " + UnumOfbathrooms + ",Unit_NumberOfRooms=" + Bnumofrooms + ",Unit_Condition='" + UCond + "',Unit_BuildingNo = " + UBuildNum + ") VALUES('" + Utype + "'," + UReqRent + "," + Ustate + "," + Uarea + "," + UnumOfbathrooms + "," + Bnumofrooms + ",'" + UCond + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteUNIT(int Uid)
        {
            string query = " DELETE FROM Units WHERE Unit_Id =" + Uid;
            return dbMan.ExecuteNonQuery(query);
        }




     

        //-----------------------------------Rent Table Related Functions-----------------------------------------------
        //pays Unpays a rent
  
     
        //-----------------------------------Employee Table Related Functions-----------------------------------------------
        //Get a Certain Employee by his ID
 
        //Get All Employees details.
        public DataTable GetEmpBySSN(int SSN)
        {
            string query = "Select *From Employees WHERE Employee_SSN = " + SSN + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetEmployee(string Mg, string Cas, string Ac)
        {


            string query = "Select * From Employees ";
            if (Mg != null)
            {
                query += " WHERE Employee_Type = '" + Mg + "' ";

                if (Cas != null)
                    query += "OR Employee_Type = '" + Cas + "'";

                if (Ac != null)
                    query += "OR Employee_Type = '" + Ac + "' ";



            }

            else if (Cas != null)
            {
                query += " WHERE Employee_Type = '" + Cas + "' ";

                if (Mg != null)
                    query += "OR Employee_Type = '" + Mg + "' ";

                if (Ac != null)
                    query += "OR Employee_Type = '" + Ac + "' ";


            }

            else if (Cas != null)
            {
                query += " WHERE Employee_Type = '" + Ac + "' ";

                if (Cas != null)
                    query += "OR Employee_Type = '" + Cas + "' ";

                if (Mg != null)
                    query += "OR Employee_Type = '" + Mg + "' ";


            }

            query += ";";
            return dbMan.ExecuteReader(query);




        }

        public int GetOwnerIDFromEmpID(int ID)
        {
            string query = "SELECT Employee_OwnerID FROM Employees WHERE Employee_ID = " + ID + ";";
            return (int)dbMan.ExecuteScalar(query);
        }


        public DataTable GetEmployeeByType(string Type)
        {
            string query = "SELECT * FROM Employees WHERE Employee_Type = '" + Type + "';";


            return (DataTable)dbMan.ExecuteReader(query);
        }
        public DataTable GetEmpId()
        {
            string query = "SELECT Employee_ID FROM Employees;";
            return (DataTable)dbMan.ExecuteReader(query);
        }
 
        public int AddEmployee(string FirstName, string LastName, int SSN, float OutstandingSalary, float Salary, DateTime HiringDate, string Type, int? MgrID, int OwnerID, int ContID)
        {
            bool Nope = true;
            if (MgrID != null)
                Nope = false;
            string query = "INSERT INTO Employees(Employee_FirstName, Employee_LastName, Employee_SSN, Employee_OutstandingSalary, Employee_Salary, Employee_HiringDate, Employee_Type,Employee_PhoneNumber,Employee_Address,Employee_MngrID,Employee_OwnerID,Employee_ContactID) VALUES" +
                "('" + FirstName +
                "','" + LastName +
                "'," + SSN +
                "," + OutstandingSalary +
                "," + Salary +
                ",'" + HiringDate.ToString("yyyy-MM-dd") +
                "','" + Type +
                "','',''," + (Nope == true ? "null" : "") + MgrID +
                "," + OwnerID +
                "," + ContID + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmployee(int ID, string FirstName, string LastName, int SSN, float OutstandingSalary, float Salary, DateTime HiringDate, string Type, int? MgrID, int OwnerID, int ContID)
        {

            bool Nope = true;
            if (MgrID != null)
                Nope = false;

            string query = "UPDATE Employees SET Employee_FirstName = '" + FirstName +
                "', Employee_LastName = '" + LastName +
                "' , Employee_SSN = " + SSN +
                " , Employee_OutstandingSalary = " + OutstandingSalary +
                " , Employee_Salary = " + Salary +
                " , Employee_HiringDate = '" + HiringDate.ToString("yyyy - MM - dd") +
                "',Employee_Type =  '" + Type +
                "' , Employee_PhoneNumber = '' , Employee_Address = ''" +
                " , Employee_MngrID = " + (Nope == true ? "null" : "") + MgrID +
                " , Employee_OwnerID = " + OwnerID +
                " , Employee_ContactID = " + ContID
                + " WHERE Employee_ID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);



        }
        public int OustandingSalaryByID(int ID)
        {
            string query = "SELECT Employee_OutstandingSalary FROM Employees WHERE Employee_ID = " + ID + ";";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int SalaryByID(int ID)
        {
            string query = "SELECT Employee_Salary FROM Employees WHERE Employee_ID = " + ID + ";";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int PayoutstandingSalary(int ID)
        {
            string query = "Update Employees SET Employee_OutstandingSalary = 0 WHERE Employee_ID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Un_Or_PayManualAmount(int ID, int Salary, int Os)
        {
            string query = "Update Employees SET Employee_OutstandingSalary = " + (Os - Salary) + " WHERE Employee_ID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }


        public int DeleteEmployee(int ID)
        {
            string query = "DELETE FROM Employees WHERE Employee_ID = " + ID;
            return dbMan.ExecuteNonQuery(query);
        }





        public int deleteBunits(object Uid)
        {
            string query = " DELETE FROM Units WHERE Unit_BuildingNo=" + Uid;
            return dbMan.ExecuteNonQuery(query);
        }

        
        

        //-------------------------------------------------------------FROM UNIT_RENT---------------------------------------------------------------
        //delete forgin keys in table unit_rents

        public int SelectUR_TId(int id)
        {
            string query = " select Count (Unit_Rents_TenantId) FROM Unit_Rents WHERE Unit_Rents_TenantId=" + id;
            return Convert.ToInt32(dbMan.ExecuteNonQuery(query));
        }

        public int SelectUR_UId(int id)
        {
            string query = "select Count (Unit_Rents_UnitId) FROM Unit_Rents WHERE Unit_Rents_UnitId=" + id;
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int deleteUR_UId(int Uid)
        {
            string query = " DELETE FROM Unit_Rents WHERE Unit_Rents_UnitId=" + Uid;
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteUR_TId(int tid)
        {
            string query = " DELETE FROM Unit_Rents WHERE Unit_Rents_TenantId=" + tid;
            return dbMan.ExecuteNonQuery(query);
        }

        //------------------------------------------------------------------


        //-----------------------------------5alas Feneeto----------------------------------------------








        //-----------------------------------User Table Related Functions-----------------------------------------------








        //-----------------------------------5alas Feneeto----------------------------------------------


        //-----------------------------------5alas Feneeto----------------------------------------------

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
