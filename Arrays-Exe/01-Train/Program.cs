/*
 *A train has n number of wagons (integer, received as input). On the next n lines, you will receive the number of people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the total number of passengers on the train.
 */

int numberOfWagons = int.Parse(Console.ReadLine());
// Number of wagons.
int[] train = new int[numberOfWagons];
// Represents total passengers on the train.
int totalPassengers = 0;
// With for-loop im gonna put the passengers and count the total.
for (int i = 0; i < train.Length; i++)
{
    int passengers = int.Parse(Console.ReadLine());

    train[i] += passengers;
    totalPassengers += passengers;
}

Console.WriteLine(string.Join(" ", train));
Console.WriteLine(totalPassengers);