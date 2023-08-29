// See https://aka.ms/new-console-template for more information
double precioConsumo, impuesto, descuento, subTotal;

Console.WriteLine("\tBoleta de pago por consumo");
Console.WriteLine("\t**************************\n");
Console.Write("Ingrese el monto inicial por consumo en soles: S/. ");
precioConsumo = double.Parse(Console.ReadLine());

descuento = 0;
subTotal = 0;
if (precioConsumo <= 100 && precioConsumo > 0)
{
    descuento = 0.1 * precioConsumo;
    subTotal = precioConsumo - descuento;
}
if (precioConsumo > 100)
{
    descuento = 0.2 * precioConsumo;
    subTotal = precioConsumo - descuento;
}
impuesto = 0.18 * subTotal;
precioConsumo = subTotal + impuesto;

Console.WriteLine("Descuento      : S/. {0}", descuento.ToString("N2"));
Console.WriteLine("Sub Total      : S/. {0}", subTotal.ToString("N2"));
Console.WriteLine("Impuesto       : S/. {0}", impuesto.ToString("N2"));
Console.WriteLine("Importe a pagar: S/. {0}", precioConsumo.ToString("N2"));
Console.ReadKey();

