class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    { 
         return  new int[7] {0,2,5,3,7,8,4};
    }

    public int Today()
    {
      return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
    birdsPerDay[birdsPerDay.Length - 1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
      foreach (int count in birdsPerDay)
      {
          if (count == 0)
          {
              return true;
          }
   
      }
     return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int suma = 0;
        for (int i = 0; i<  numberOfDays; i++){
          suma += birdsPerDay[i];
        }

        return suma;
    }

    public int BusyDays()
    {
      int diasOcupados = 0;
        foreach (int contador in  birdsPerDay){
         if (contador >=  5)
         {
             diasOcupados += 1;
         }   
        }
        return diasOcupados;
    }
}
