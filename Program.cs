﻿class CustomersVehicle
{
    public CustomersVehicle(string dataplateNum, string datavehicleType, int dataparkingLot)
    {
        plateNumInfo = dataplateNum;
        vehicleTypeInfo = datavehicleType;
        parkingLotInfo = dataparkingLot;
    }
    private string plateNumInfo;
    public string PlateNum
    {
        get { return plateNumInfo; }
    }
    private string vehicleTypeInfo;
    public string VehicleType
    {
        get { return vehicleTypeInfo; }
    }
    private int parkingLotInfo;
    public int ParkingLot
    {
        get { return parkingLotInfo; }
    }
    DateTime tempDate = DateTime.Now;
}
class program
{
    public static void Main(string[] args)
    {
        List<CustomersVehicle> vehiclesList = new List<CustomersVehicle>(100);
        int menyVal;
        Console.WriteLine("<<<<<<<<<<<<<<<<<<<<¤>>>>>>>>>>>>>>>>>>>>" //20st. var sin sida. bara för att komma ihåg
            +"\n<<     Welcome to our luxury garage    >>"
            +"\n<<     Current vehicle:" + vehiclesList.Count+ "               >>"
            +"\n<<<<<<<<<<<<<<<<<<<<¤>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine();
        do
        {
            Console.WriteLine("Please choose from the menu options"
                + "\n1: Add New Customer"
                + "\n2: Remove Customer"
                + "\n3: View Lot"
                + "\n4: Find Vehicle"
                + "\n0: Exit Program");
            menyVal = int.Parse(Console.ReadLine());
            switch (menyVal)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Please write the plate number of the vehicle.");
                    string plateNumInfo = Console.ReadLine();
                    Console.WriteLine("Please write the type of the vehicle.");
                    string vehicleTypeInfo = Console.ReadLine();
                    Console.WriteLine("Please write the parking lot number.");
                    Int32.TryParse(Console.ReadLine(), out int parkingLotInfo);

                    Console.WriteLine("The vehicle is now in the system");
                    CustomersVehicle newVehicle = new CustomersVehicle(plateNumInfo, vehicleTypeInfo, parkingLotInfo);
                    vehiclesList.Add(newVehicle);

                    break;
                case 2:
                    Console.Write("Choose the vehicle you want to remove [0 Cancel]: ");
                    int removeVehicle = Convert.ToInt32(Console.ReadLine());
                    //vehiclesList.Remove(removeVehicle);
                    break;
                case 3:
                    Console.Clear();
                    foreach (CustomersVehicle vehicle in vehiclesList)
                    {
                        Console.WriteLine("License Number: " + vehicle.PlateNum + " - " + "Type: " + vehicle.VehicleType + " - " + "Lot: " + vehicle.ParkingLot);
                    }
                    break;
                case 4:
                    Console.WriteLine("Witch vehicle do you want to find? Please write the license number");
                    string licenseNum = Console.ReadLine();
                    bool currentVehicle = false;
                    for (int i = 0; i < vehiclesList.Count; i++)
                    {
                        if (vehiclesList[i].PlateNum == licenseNum)
                        {
                            Console.WriteLine("The current vehicle is on the list");
                            Console.WriteLine("License Number: " + vehiclesList[i].PlateNum + " - " + "Type: " + vehiclesList[i].VehicleType + " - " + "Lot: " + vehiclesList[i].ParkingLot);
                            currentVehicle = true;
                            break;
                        }
                    }
                    if (!currentVehicle)
                    {
                        Console.WriteLine("There is no vehicle in the garage that match your license number.");
                    }
                    break;
                case 0:
                    menyVal = 0;
                    break;
                default:
                    Console.WriteLine("Oopsi Daisy. Something went wrong. Please try again!");
                    break;
            }
        }
        while (menyVal != 0);
    }
}


/*class Garage
{
    CustomersVehicle[] vehiclesArray = new CustomersVehicle[100];
    public int currentVehicle;
    public void Run()
    {
        //Här tänkte jag att huvud meny skall vara.
        int menyVal;
        Console.WriteLine("Welcome to our luxury garage");
        do
        {
            Console.WriteLine("Please choose from the menu options"
                + "\n1: Add New Customer"
                + "\n2: Remove Customer"
                + "\n3: View Lot"
                + "\n4: Find Vehicle"
                + "\n5: Sort Lot"
                + "\n0: Exit Program");
            menyVal = int.Parse(Console.ReadLine());
            switch (menyVal)
            {
                case 1:
                    Add_vehicle(customersVehicle: CustomersVehicle);
                    break;
                case 2:
                    Remove_vehicle();
                    break;
                case 3:
                    Print_vehicle();
                    break;
                case 4:
                    Find_vehicle();
                    break;
                case 5:
                    Sort_parking_lot();
                    break;
                case 0:
                    menyVal = 0;
                    break;
                default:
                    Console.WriteLine("Oopsi Daisy. Something went wrong. Please try again!");
                    break;
            }
        }
        while (menyVal !=0);
    }
    public void Add_vehicle(CustomersVehicle customersVehicle)
    {
        Console.Clear();
        Console.WriteLine("How many vehicle do you want to park?");
        try
        {
            int pLot = Convert.ToInt32(Console.ReadLine());
            if (pLot > vehiclesArray.Length)
            {
                Console.WriteLine("The garage is full at the moment. Please come back again later!");
            }
            else
            {
                for (int i = 0; i < pLot; i++) //här kanske kan lägga in if-satser när gäller OM bil eller OM MC
                {
                    Console.WriteLine("Please write the plate number of the vehicle.");
                    string plateNum = Console.ReadLine();
                    Console.WriteLine("Please write the type of the vehicle.");
                    string typeOfVehicle = Console.ReadLine();
                    Console.WriteLine("Please write the parking lot number.");
                    Console.WriteLine("The vehicle is now in the system");
                    CustomersVehicle = vehiclesArray[i](plateNum, typeOfVehicle);
                    currentVehicle++;
                }
            }
        }
        catch
        {
            Console.WriteLine("Oopsi Daisy. Something went wrong. Please try again!");
        }
    }
    public void Remove_vehicle()
    {
        //tar bort fordon
    }
    public void Print_vehicle()
    {
        Console.Clear();
        for (int i = 0; i < vehicles.Length; i++)
        {
            Console.WriteLine("");
        }
    }
    public void Find_vehicle()
    {
        //Söka fordon i systemet genom att använda räckvidd t.ex. parkerings kvitto mellan nr. 2-5
        Console.Clear ();
        Console.WriteLine("");
    }
    public void Sort_parking_lot()
    {
        //Sorterar parkerings plats och flyttar dem.
    }
}
/*class CustomersVehicle
{
    private string plateNumInfo;
    public string PlateNum
    {
        get { return plateNumInfo; }
    }
    private string vehicleTypeInfo;
    public string VehicleType
    {
        get { return vehicleTypeInfo; }
    }
    public CustomersVehicle(string dataplateNum, string datavehicleType)
    {
        plateNumInfo = dataplateNum;
        vehicleTypeInfo = datavehicleType;
    }
}
class ParkingNumber
{
    private String lotNumber;
    private CustomersVehicle ownersVehicle;
    private DateTime entryTime;
    private DateTime exitTime;

    public ParkingNumber(String lotNumber, CustomersVehicle ownersVehicle, DateTime entryTime, DateTime exitTime)
    {
        this.lotNumber = lotNumber;
        this.ownersVehicle = ownersVehicle;
        this.entryTime = entryTime;
    }
    public String getLotNumber()
    {
        return lotNumber;
    }
    public void setLotNumber(String lotNumber)
    {
        this.lotNumber = lotNumber;
    }
    public CustomersVehicle getOwnersVehicle()
    {
        return ownersVehicle;
    }
    public void setOwnersVehicle(CustomersVehicle ownersVehicle)
    {
        this.ownersVehicle = ownersVehicle;
    }
    public DateTime getEntryTime()
    {
        return entryTime;
    }
    public void setEntryTime(DateTime entryTime)
    {
        this.entryTime = entryTime;
    }
    public DateTime getExitTime()
    {
        return exitTime;
    }
    public void setExitTime(DateTime exitTime)
    {
        this.exitTime = exitTime;
    }
}
class GaragesLot
{

}*/ // Kanske kan användas till version 2 av Prague Parking
/*class Vehicles
{
    public static void Main(string[] args)
    {
        List<CustomersVehicle> vehicleList = new List<CustomersVehicle>();
        var parkgarage = new Garage();
        parkgarage.Run();
        Console.Write("Tryck Enter för att fortsätta...");
        Console.ReadKey(true);
    }  //Här körs hela programmet och anropar alla class och metoder

}*/