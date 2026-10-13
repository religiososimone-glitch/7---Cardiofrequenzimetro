int eta, bpm;
const int VOLTE = 10, COSTANTE_CALCOLO1 = 220;
float sogliaAnaerobica;
const float COSTANTE_CALCOLO2 = 0.935f;

Console.WriteLine("Inserire l'eta' dell' atleta");
eta = Convert.ToInt16(Console.ReadLine());

sogliaAnaerobica = (COSTANTE_CALCOLO1 - eta) * COSTANTE_CALCOLO2;