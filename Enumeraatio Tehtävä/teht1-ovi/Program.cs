using System;
string currDoorState = "Päätä oven tila";

while (0 == 0)
{
    Console.WriteLine("ovi on " + currDoorState + " Mitä haluaisit tehdä: " );
    if (Enum.TryParse<DoorState>(Console.ReadLine(), ignoreCase: true, out var state))
    {

        
        switch (state)
        {
            
            case DoorState.auki:
                if (currDoorState == "Päätä oven tila" || currDoorState == "Kiinni")
                {
                    currDoorState = "Auki";
                }
                else
                {
                    Console.WriteLine("Voit vain laittaa oven kiinni");
                }
                break;
                
            case DoorState.lukitse:
                if (currDoorState == "Päätä oven tila" || currDoorState == "Kiinni")
                {
                    currDoorState = "Lukitse";
                }
                else
                {
                    Console.WriteLine("Voit vain laittaa oven kiinni");
                }
                    
                break;
            case DoorState.kiinni:
                if (currDoorState == "Päätä oven tila" || currDoorState == "Auki" || currDoorState == "Lukitse")
                {
                    currDoorState = "Kiinni";
                }
                    
                break;
            default:
                break;
        }
    }
    else
    {
        Console.WriteLine("Et pysty tekemään näin");
    }
   
}
enum DoorState
{
    lukitse,
    kiinni,
    auki,


}


