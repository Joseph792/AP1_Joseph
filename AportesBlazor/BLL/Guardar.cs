//using AportesBlazor.DAL;
//using AportesBlazor.Models;

//namespace AportesBlazor.BLL
//{
//    public static bool Guardar(Aportes aporte)
//    {
//        if (!Existe(aporte.AporteId))
//            return Insertar(aporte);
//        else
//            return Modificar(aporte);
//    }

//    public static bool Existe(int id)
//    {
//        Contexto contexto = new Contexto();
//        bool encontrado = false;

//        try
//        {
//            encontrado = contexto.Aportes.Any(e => e.AporteId == id);
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {
//            contexto.Dispose();
//        }
//        return encontrado;
//    }
//}
