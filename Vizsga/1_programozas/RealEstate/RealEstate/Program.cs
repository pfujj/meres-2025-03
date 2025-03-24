using RealEstate;

List<Ad> ad = Ad.load(@"C:\Users\goczad.20d\Desktop\Vizsga\1_programozas\realestates.csv");

int sum = 0;
int num = 0;

int legkozindex = 0;
double legkoztav = ad[0].distanceTo("47.4164220114023,19.066342425796986");

for (int i = 0; i < ad.Count; i++)
{
    if (ad[i].getFloors() == 0)
    {
        num++;
        sum += ad[i].getArea();
    }

    double tav = ad[i].distanceTo("47.4164220114023,19.066342425796986");
    if (tav < legkoztav)
    {
        legkoztav = tav;
        legkozindex = i;
    }
}

Console.Write("Átlagos alapterület: ");
Console.WriteLine((double)sum / num);

Console.WriteLine();

Console.Write("Legközelebbi tehermentes ingatlan: ");
Console.WriteLine(ad[legkozindex].getDetails());