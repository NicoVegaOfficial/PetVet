using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Pet_Vet_1
{
    class conexionsqlserver
    {
        static public SqlConnection conn;

        public void abrir()
        {
            try
            {
                conn = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_PET_VET;Integrated Security=True");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la BD " + ex.Message);
            }
        }
        public void cerrar()
        {
            conn.Close();
        }

        public void consultar(string consulta)
        {
            string sqlSelect = "select * from Animal where Nombre = '" + consulta + "'";
            List<string> nombre = new List<string>();
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlSelect,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {
                    nombre.Add(r.ToString());
                    MessageBox.Show(nombre[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void eliminar(string IdAnimal)
        {
            string sqlDelete = "delete from animal where IdAnimal = " + IdAnimal + ";";

            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlDelete,
            };
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("El animal se eliminó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void eliminarCliente(string IdCliente)
        {
            string sqlDelete = "delete from Cliente where IdCliente = " + IdCliente + ";";

            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlDelete,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {

                }

                MessageBox.Show("El cliente se eliminó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void eliminarVeterinario(string IdVeterinario)
        {
            string sqlDelete = "delete from Veterinario where IdVeterinario = " + IdVeterinario + ";";

            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlDelete,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {

                }

                MessageBox.Show("El veterinario se eliminó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //i es una variable para asignarla al idAnimal
        int i;
        public void insertar(string idCliente, string Nombre, string especie, string raza, string color, DateTime Fecha_Nacimiento)
        {
            //Este comando pide el último registro de la tabla Animal
            string sqlSelect = "select top 1 * from Animal order by IdAnimal desc";
            List<string> id = new List<string>();
            string idNuevo;
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlSelect,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {
                    //Seleccionamos la columna idAnimal, lo pasamos a entero y la guardamos en idNuevo
                    idNuevo = r["idAnimal"].ToString();
                    id.Add(idNuevo);
                    //Guardamos el valor en este caso entero de idNuevo a la variable i
                    i = int.Parse(idNuevo);
                    i = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 " + ex.Message);
            }
            finally
            {

                conn.Close();
            }
            //Le paso los valores previamente introducidos en el Formulario, pero IdAnimal los obtiene desde la variable i
            string sqlInsert = "insert into Animal (IdAnimal, IdCliente, Nombre, Especie, Raza, Color, Fecha_Nacimiento) values (" + i + ", " + idCliente + ", '" + Nombre + "', '" + especie + "', '" + raza + "', '" + color + "', '" + Fecha_Nacimiento.ToString() + "')";
            List<string> id2 = new List<string>();
            SqlCommand comm2 = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlInsert,
            };
            try
            {
                conn.Open();
                SqlDataReader rr = comm2.ExecuteReader();
                while (rr.Read())
                {
                }
                MessageBox.Show("El animal se añadió correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2 " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void insertarCliente(string Nombre, string segundoNombre, string Apellido, string CedulaIdentidad, string CuentaBancaria, string direccion, string telefono, string ciudad)
        {
            //Este comando pide el último registro de la tabla Animal
            string sqlSelect = "select top 1 * from Cliente order by IdCliente desc";
            List<string> id = new List<string>();
            string idNuevo;
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlSelect,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {
                    //Seleccionamos la columna idAnimal, lo pasamos a entero y la guardamos en idNuevo
                    idNuevo = r["idCliente"].ToString();
                    id.Add(idNuevo);
                    //Guardamos el valor en este caso entero de idNuevo a la variable i
                    i = int.Parse(idNuevo);
                    i = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 " + ex.Message);
            }
            finally
            {

                conn.Close();
            }
            //Le paso los valores previamente introducidos en el Formulario, pero IdAnimal los obtiene desde la variable i
            string sqlInsert = "insert into Cliente (IdCliente, Nombre, SegundoNombre, Apellido, CedulaIdentidad, CuentaBancaria, Direccion, Telefono, Ciudad) values (" + i + ", '" + Nombre + "', '" + segundoNombre + "', '"
                + Apellido + "', " + CedulaIdentidad + ", " + CuentaBancaria + ", '" + direccion + "', '" + telefono + "', '" + ciudad + "');";
            List<string> id2 = new List<string>();
            SqlCommand comm2 = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlInsert,
            };
            try
            {
                conn.Open();
                SqlDataReader rr = comm2.ExecuteReader();
                while (rr.Read())
                {
                }
                MessageBox.Show("El cliente se añadió correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2 " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void insertarVeterinario(string Nombre, string Apellido)
        {
            //Este comando pide el último registro de la tabla Animal
            string sqlSelect = "select top 1 * from Veterinario order by IdVeterinario desc";
            List<string> id = new List<string>();
            string idNuevo;
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlSelect,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {
                    //Seleccionamos la columna idAnimal, lo pasamos a entero y la guardamos en idNuevo
                    idNuevo = r["IdVeterinario"].ToString();
                    id.Add(idNuevo);
                    //Guardamos el valor en este caso entero de idNuevo a la variable i
                    i = int.Parse(idNuevo);
                    i = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 " + ex.Message);
            }
            finally
            {

                conn.Close();
            }
            //Le paso los valores previamente introducidos en el Formulario, pero IdAnimal los obtiene desde la variable i
            string sqlInsert = "insert into Veterinario (IdVeterinario, Nombre, Apellido) values (" + i + ", '" + Nombre + "', '" + Apellido + "');";
            List<string> id2 = new List<string>();
            SqlCommand comm2 = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlInsert,
            };
            try
            {
                conn.Open();
                SqlDataReader rr = comm2.ExecuteReader();
                while (rr.Read())
                {
                }
                MessageBox.Show("El veterinario se añadió correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2 " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void modificar(string nombre, string especie, string raza, string color, string fechaNacimiento, string idAnimal)
        {
            //string sqlDelete = "delete from animal where nombre = '" + nombreAnimal + "';";
            string updatesql = "update Animal set Nombre = '" + nombre + "', Especie = '" + especie + "', Raza = '" + raza + "', Color = '" + color + "', Fecha_Nacimiento = '" + fechaNacimiento + "'  where IdAnimal =" + idAnimal;

            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = updatesql,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {

                }

                MessageBox.Show("El animal se modificó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            };

        }
        public void modificarCliente(string idCliente, string nombre, string segundonombre, string apellido, string cedulaidentidad, string cuentabancaria, string direccion, string telefono, string ciudad)
        {
            //update Cliente = nombre = Juan segundonombre =  Carlos  apellido =  Dibot cedulaidentidad =  45683958  cuentabancaria =  987554264  direccion  =  Rincon 781  telefono =  099111229  ciudad =  Canelones  where idCliente =  6
            string updateCliente = "update Cliente set nombre = '" + nombre + "', segundonombre =  '" + segundonombre + "',  apellido =  '" + apellido
                + "', cedulaidentidad =  '" + cedulaidentidad + "',  cuentabancaria =  '" + cuentabancaria + "',  direccion "
                + " =  '" + direccion + "',  telefono =  '" + telefono + "',  ciudad =  '" + ciudad + "'  where idCliente =  '" + idCliente + "';";
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = updateCliente,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {

                }

                MessageBox.Show("El cliente se modificó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            };
        }
        public void modificarVeterinario(string idVeterinario, string nombre, string apellido)
        {
            //update Cliente = nombre = Juan segundonombre =  Carlos  apellido =  Dibot cedulaidentidad =  45683958  cuentabancaria =  987554264  direccion  =  Rincon 781  telefono =  099111229  ciudad =  Canelones  where idCliente =  6
            string updateCliente = "update Veterinario set nombre = '" + nombre + "', apellido =  '" + apellido + "' where idVeterinario = '" + idVeterinario + "';";
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = updateCliente,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {

                }

                MessageBox.Show("El veterinario se modificó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            };
        }
        public void eliminarEnfermedad(string IdEnfermedad)
        {
            string sqlDelete = "delete from Enfermedad where IdEnfermedad = " + IdEnfermedad + ";";

            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlDelete,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {

                }

                MessageBox.Show("La enfermedad se eliminó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void insertarEnfermedad(string Nombre)
        {
            //Este comando pide el último registro de la tabla Enfermedad
            string sqlSelect = "select top 1 * from Enfermedad order by IdEnfermedad desc";
            List<string> id = new List<string>();
            string idNuevo;
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlSelect,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {
                    //Seleccionamos la columna idEnfemedad, lo pasamos a entero y la guardamos en idNuevo
                    idNuevo = r["idEnfermedad"].ToString();
                    id.Add(idNuevo);
                    //Guardamos el valor en este caso entero de idNuevo a la variable i
                    i = int.Parse(idNuevo);
                    i = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 " + ex.Message);
            }
            finally
            {

                conn.Close();
            }
            //Le paso los valores previamente introducidos en el Formulario, pero IdEnfermedad los obtiene desde la variable i
            string sqlInsert = "insert into Enfermedad (IdEnfermedad, Nombre) values (" + i + ", '" + Nombre + "')";
            List<string> id2 = new List<string>();
            SqlCommand comm2 = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlInsert,
            };
            try
            {
                conn.Open();
                SqlDataReader rr = comm2.ExecuteReader();
                while (rr.Read())
                {
                }
                MessageBox.Show("La enfermedad se añadió correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2 " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool modificarEnfermedad(string IdEnfermedad, string nombre)
        {
            //string sqlDelete = "delete from enfermedad where nombre = '" + nombreEnfermedad + "';";
            string updatesql = "update Enfermedad set Nombre = '" + nombre + "' where IdEnfermedad = " + IdEnfermedad;
            int r = 0;
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = updatesql,
            };
            try
            {
                conn.Open();
                r = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            };
            return r > 0;
        }

        public void eliminarHC(string Idhc)
        {
            string sqlDelete = "delete from HistoriaClinica where IdHistoriaClinica = " + Idhc + ";";
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlDelete,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {

                }

                MessageBox.Show("La historia clinica se eliminó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();


            }
        }
        public void insertarFechaVacuna(string idVacuna, string idAnimal, string fechaVacuna)
        {
            //Este comando pide el último registro de la tabla Enfermedad
            string sqlSelect = "select top 1 * from VacunaAnimal order by IdVacunaAnimal desc";
            List<string> id = new List<string>();
            string idNuevo;
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlSelect,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {
                    //Seleccionamos la columna idEnfemedad, lo pasamos a entero y la guardamos en idNuevo
                    idNuevo = r["idVacunaAnimal"].ToString();
                    id.Add(idNuevo);
                    //Guardamos el valor en este caso entero de idNuevo a la variable i
                    i = int.Parse(idNuevo);
                    i = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 " + ex.Message);
            }
            finally
            {

                conn.Close();
            }
            //Le paso los valores previamente introducidos en el Formulario, pero IdEnfermedad los obtiene desde la variable i
            string sqlInsert = "insert into VacunaAnimal (IdVacunaAnimal, idVacuna, idAnimal, Fecha_Vacuna) values (" + i + ", '" + idVacuna + "', " + idAnimal + "', '" + fechaVacuna + "');";
            List<string> id2 = new List<string>();
            SqlCommand comm2 = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlInsert,
            };
            try
            {
                conn.Open();
                SqlDataReader rr = comm2.ExecuteReader();
                while (rr.Read())
                {
                }
                MessageBox.Show("La fecha de vacuna se añadió correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2 " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void EliminarVacunaAnimal(string idVacunaAnimal)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from VacunaAnimal where IdVacunaAnimal = " + idVacunaAnimal;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void insertarHC(string idAnimal, string idVeterinario, string idEnfermedad, string fechaEnfermedad)
        {
            //Este comando pide el último registro de la tabla Enfermedad
            string sqlSelect = "select top 1 * from HistoriaClinica order by idHistoriaClinica desc";
            List<string> id = new List<string>();
            string idNuevo;
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlSelect,
            };
            try
            {
                conn.Open();
                SqlDataReader r = comm.ExecuteReader();
                while (r.Read())
                {
                    //Seleccionamos la columna idEnfemedad, lo pasamos a entero y la guardamos en idNuevo
                    idNuevo = r["idHistoriaClinica"].ToString();
                    id.Add(idNuevo);
                    //Guardamos el valor en este caso entero de idNuevo a la variable i
                    i = int.Parse(idNuevo);
                    i = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 " + ex.Message);
            }
            finally
            {

                conn.Close();
            }
            //Le paso los valores previamente introducidos en el Formulario, pero IdEnfermedad los obtiene desde la variable i
            string sqlInsert = "insert into HistoriaClinica (idHistoriaClinica, idAnimal, idVeterinario, idEnfermedad, Fecha_Enfermedad) values (" + i + ", " + idAnimal + ", " + idVeterinario + ", " + idEnfermedad + ", '" + fechaEnfermedad + "');";
            List<string> id2 = new List<string>();
            SqlCommand comm2 = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = sqlInsert,
            };
            try
            {
                conn.Open();
                SqlDataReader rr = comm2.ExecuteReader();
                while (rr.Read())
                {
                }
                MessageBox.Show("La historia clinica se añadió correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2 " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
