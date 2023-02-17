using System;
DoorState currentState = DoorState.kiinni;

while (0 == 0)
{
    Console.WriteLine("ovi on " + Convert.ToString(currentState) + " Mitä haluaisit tehdä: " );
    if (Enum.TryParse<DoorState>(Console.ReadLine(), ignoreCase: true, out var state))
    {

        
        switch (state)
        {
            
            case DoorState.auki:
                if (currentState == DoorState.kiinni)
                {
                    currentState = DoorState.auki;
                }
                else
                {
                    Console.WriteLine("Voit vain laittaa oven kiinni");
                }
                break;
                
            case DoorState.lukitse:
                if (currentState == DoorState.kiinni)
                {
                    currentState = DoorState.lukitse;
                }
                else
                {
                    Console.WriteLine("Voit vain laittaa oven kiinni");
                }
                    
                break;
            case DoorState.kiinni:
                if (currentState == DoorState.auki || currentState == DoorState.lukitse)
                {
                    currentState = DoorState.kiinni;
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


