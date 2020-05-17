using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
	public class BackendDetails
	{
		SqlConnection con = new SqlConnection(@"Data Source = localhost; Initial Catalog = Hospital Management; Integrated Security = True");

		/// <summary>
		/// This method was used to view the all doctor details in Datagridview applicable for all roles.
		/// </summary>
		private void ViewDoctorDetails()
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = "Select ID, DoctorName, Age, Gender, Email, ContactNo, [Specialist In] from DoctorDetails";

				SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, con);

				DataTable DoctorDetails = new DataTable();
				adapter.Fill(DoctorDetails);
				adapter.Dispose();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to get the particular doctor details from the datagridview which was applicable for Admin Role.
		/// </summary>
		/// <param name="id"></param>
		private void GetDoctorDetailsById(int id)
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = "Select * from DoctorDetails where Id = @Id";
				command.CommandType = CommandType.Text;
				command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					Console.WriteLine(
						reader["ID"].ToString(),
						reader["DoctorName"].ToString(),
						reader["Age"].ToString(),
						reader["Gender"].ToString(),
						reader["Address"].ToString(),
						reader["Email"].ToString(),
						reader["[Contact No]"].ToString(),
						reader["[Specialist In]"].ToString(),
						reader["Salary"].ToString()
						);
				}
				reader.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to update the doctor details which was only applicable for admin Role.
		/// </summary>
		private void UpdateDoctorDetails(int id)
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = @"Update DoctorDetails set 
										DoctorName = @DoctorName, 
										Age = @Age, 
										Gender= @Gender, 
										Address = @Address,
										Email = @Email,
										[Contact No] = @ContactNo,
										[Specialist In] = @SpecialistIn,
										[Salary] = @Salary
										where Id = @Id";

				command.Connection = con;
				command.CommandType = CommandType.Text;

				//These details from the admin when we select the particular Doctor ID from Datagrid

				//command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
				//command.Parameters.Add("@DoctorName", SqlDbType.VarChar,20).Value = doctorName;
				//command.Parameters.Add("@Age", SqlDbType.Int).Value = age;
				//command.Parameters.Add("@Gender", SqlDbType.VarChar,10).Value = gender;
				//command.Parameters.Add("@Address", SqlDbType.VarChar,255).Value = address;
				//command.Parameters.Add("@Email", SqlDbType.VarChar,50).Value = email;
				//command.Parameters.Add("@ContactNo", SqlDbType.BigInt).Value = contactNo;
				//command.Parameters.Add("@SpecialistIn", SqlDbType.VarChar, 10).Value = specialist;
				//command.Parameters.Add("@Salary", SqlDbType.VarChar, 20).Value = salary;

				var result = command.ExecuteNonQuery();
				command.Dispose();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to insert the patient details into the DB.
		/// </summary>
		private void AddPatientdetails()
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = @"Insert into PatientDetails(Name,Age,Gender,Address,[Contact No],Diease,DoctorId,RoomType,[CheckIn Date],Building,[Room No], Price,[Status]) values
										Name = @Name, 
										Age = @Age, 
										Gender= @Gender, 
										Address = @Address,
										[Contact No] = @ContactNo,
										Diease = @Diease,
										DoctorId = @DoctorId,
										RoomType = @RoomType,
										[CheckIn Date] = @CheckInDate,
										Building = @Building,
										[Room No] = @RoomNo,
										Price = @Price,
										[Status] = @Status";

				command.Connection = con;
				command.CommandType = CommandType.Text;

				//These details from the admin when we select the particular Doctor ID from Datagrid

				//command.Parameters.Add("@Name", SqlDbType.VarChar,30).Value = Name;
				//command.Parameters.Add("@Age", SqlDbType.Int).Value = age;
				//command.Parameters.Add("@Gender", SqlDbType.VarChar,10).Value = gender;
				//command.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
				//command.Parameters.Add("@ContactNo", SqlDbType.Int).Value = contactNo;

				//command.Parameters.Add("@Diease", SqlDbType.VarChar,20).Value = Diease;
				//command.Parameters.Add("@DoctorId", SqlDbType.Int).Value = DoctorId;
				//command.Parameters.Add("@RoomType", SqlDbType.VarChar,20).Value = RoomType;
				//command.Parameters.Add("@CheckInDate", SqlDbType.DateTime).Value = CheckInDate;
				//command.Parameters.Add("@Building", SqlDbType.VarChar,20).Value = Building;
				//command.Parameters.Add("@RoomNo", SqlDbType.Int).Value = RoomNo;
				//command.Parameters.Add("@Price", SqlDbType.VarChar,10).Value = Price;
				//command.Parameters.Add("@Status", SqlDbType.VarChar,10).Value = Status;

				var result = command.ExecuteNonQuery();
				command.Dispose();

				//UpdateWardDetails();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to view the all patients details which was applicable for all roles.
		/// </summary>
		private void ViewAllPatients()
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = "Select * from PatientDetails";

				SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, con);

				DataTable PatientDetails = new DataTable();
				adapter.Fill(PatientDetails);
				adapter.Dispose();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to get the patient details based on ID.
		/// </summary>
		/// <param name="id"></param>
		private void GetPatientDetailsById(int id)
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = "Select * from PatientDetails where Id = @Id";
				command.CommandType = CommandType.Text;
				command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					Console.WriteLine(
						reader["ID"].ToString(),
						reader["Name"].ToString(),
						reader["Age"].ToString(),
						reader["Gender"].ToString(),
						reader["Address"].ToString(),
						reader["[Contact No]"].ToString(),
						reader["Diease"].ToString(),
						reader["Doctor Id"].ToString(),
						reader["[Room Type]"].ToString(),
						reader["[CheckIn Date]"].ToString(),
						reader["Building"].ToString(),
						reader["[Room No]"].ToString(),
						reader["Price"].ToString(),
						reader["Status"].ToString()
						);
				}
				reader.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to update the particular patient details.
		/// </summary>
		/// <param name="id"></param>
		private void UpdatePatientDetails(int id)
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = @"Update PatientDetails set 
										Name = @Name, 
										Age = @Age, 
										Gender= @Gender, 
										Address = @Address,
										[Contact No] = @ContactNo,
										Diease = @Diease,
										[Doctor Id] = @DoctorId,
										[Room Type] = @RoomType,
										[CheckIn Date] = @CheckInDate,
										Building = @Building,
										[Room No] = @RoomNo,
										Price = @Price,
										Status = @Status
										where Id = @Id";

				command.Connection = con;
				command.CommandType = CommandType.Text;

				//These details from the user when we select the particular patient ID from Datagrid

				//command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
				//command.Parameters.Add("@DoctorName", SqlDbType.VarChar,20).Value = doctorName;
				//command.Parameters.Add("@Age", SqlDbType.Int).Value = age;
				//command.Parameters.Add("@Gender", SqlDbType.VarChar,10).Value = gender;
				//command.Parameters.Add("@Address", SqlDbType.VarChar,255).Value = address;
				//command.Parameters.Add("@ContactNo", SqlDbType.BigInt).Value = contactNo;
				//command.Parameters.Add("@Diease", SqlDbType.VarChar,20).Value = diease;
				//command.Parameters.Add("@DoctorId", SqlDbType.Int).Value = doctorId;
				//command.Parameters.Add("@RoomType", SqlDbType.VarChar,20).Value = roomType;
				//command.Parameters.Add("@CheckInDate", SqlDbType.DateTime).Value = checkinDate;
				//command.Parameters.Add("@Building", SqlDbType.VarChar,20).Value = building;
				//command.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNo;
				//command.Parameters.Add("@Price", SqlDbType.VarChar,10).Value = price;
				//command.Parameters.Add("@Status", SqlDbType.VarChar,10).Value = status;

				var result = command.ExecuteNonQuery();
				command.Dispose();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to insert the details into discharge table and update the patient details in patient table.
		/// </summary>
		/// <param name="id"></param>
		private void SaveDischargePatient(int id)
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = @"Update PatientDetails set 										
										Price = @Price,
										Status = @Status
										where Id = @Id";

				command.Connection = con;
				command.CommandType = CommandType.Text;

				//These details from the user when we select the particular patient ID from Datagrid
				
				//command.Parameters.Add("@Price", SqlDbType.VarChar,10).Value = price;
				//command.Parameters.Add("@Status", SqlDbType.VarChar,10).Value = status;

				var result = command.ExecuteNonQuery();
				command.Dispose();

				SqlCommand command1 = new SqlCommand();
				command1.CommandText = @"Insert Into DischargeDetails([Patient Id],[CheckIn Date],[CheckOut Date],[Discharge Status],[Additional Charge],[Total Price]) values
										[Patient Id] = @PatientId, 
										[CheckIn Date] = @CheckInDate, 
										[CheckOut Date]= @CheckOutDate, 
										[Discharge Status] = @DischargeStatus,
										[Additional Charge] = @Charge,
										[Total Price] = @Price";

				command1.Connection = con;
				command1.CommandType = CommandType.Text;

				//These details from the user when we select the particular patient ID from Datagrid

				//command.Parameters.Add("@PatientId", SqlDbType.Int).Value = patientId;
				//command.Parameters.Add("@CheckInDate", SqlDbType.DateTime).Value = checkInDate;
				//command.Parameters.Add("@CheckOutDate", SqlDbType.DateTime).Value = checkOutDate;
				//command.Parameters.Add("@DischargeStatus", SqlDbType.VarChar,10).Value = status;
				//command.Parameters.Add("@Charge", SqlDbType.VarChar,10).Value = charge;
				//command.Parameters.Add("@Price", SqlDbType.VarChar,10).Value = price;

				var result1 = command.ExecuteNonQuery();

				//UpdateWardDetails();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to insert the ward details into the roomdetails Table.
		/// </summary>
		private void SaveWardDetails()
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = @"Insert into RoomDetails(Building,[Room Type],[Room No],Price,[Status]) values
										Building = @Building, 
										[Room Type] = @RoomType, 
										[Room No]= @RoomNo, 
										Price = @Price,
										[Status] = @Status";

				command.Connection = con;
				command.CommandType = CommandType.Text;

				//command.Parameters.Add("@Building", SqlDbType.VarChar,20).Value = building;
				//command.Parameters.Add("@RoomType", SqlDbType.VarChar,20).Value = roomType;
				//command.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNo;
				//command.Parameters.Add("@Price", SqlDbType.VarChar,10).Value = price;
				//command.Parameters.Add("@Status", SqlDbType.VarChar,10).Value = status;

				var result = command.ExecuteNonQuery();
				command.Dispose();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to update the room status.It was called when patient was added and discharged
		/// </summary>
		/// <param name="building"></param>
		/// <param name="roomType"></param>
		/// <param name="roomNo"></param>
		private void UpdateWardDetails(string building, string roomType, int roomNo)
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = @"Update RoomDetails set 
										[Status] = @Status
										where Building = @Building and [Room Type] = @RoomType and [Room No] = @RoomNo";

				command.Connection = con;
				command.CommandType = CommandType.Text;

				//command.Parameters.Add("@Status", SqlDbType.VarChar,10).Value = "Free";
				//command.Parameters.Add("@Building", SqlDbType.VarChar,20).Value = building;
				//command.Parameters.Add("@RoomType", SqlDbType.VarChar,20).Value = roomType;
				//command.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNo;

				var result = command.ExecuteNonQuery();
				command.Dispose();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to get the all roomnos based on building and room types.
		/// </summary>
		/// <param name="building"></param>
		/// <param name="roomType"></param>
		private void GetRoomNo(string building, string roomType)
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = "Select * from RoomDetails where Building = @Building and [Room Type] = @RoomType";
				command.CommandType = CommandType.Text;
				command.Parameters.Add("@Building", SqlDbType.VarChar,20).Value = building;
				command.Parameters.Add("@RoomType", SqlDbType.VarChar, 20).Value = roomType;


				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					Console.WriteLine(
						reader["RoomNo"].ToString()
						);
				}
				reader.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to get the all information of rooms like price and status etc... based on building, room types and selected room no.
		/// </summary>
		/// <param name="building"></param>
		/// <param name="roomType"></param>
		/// <param name="roomNo"></param>
		private void GetRoomInformation(string building, string roomType, string roomNo)
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = "Select * from RoomDetails where Building = @Building and [Room Type] = @RoomType and [Room No]=@RoomNo";
				command.CommandType = CommandType.Text;
				command.Parameters.Add("@Building", SqlDbType.VarChar, 20).Value = building;
				command.Parameters.Add("@RoomType", SqlDbType.VarChar, 20).Value = roomType;
				command.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNo;


				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					Console.WriteLine(
						reader["Price"].ToString(),
						reader["[Status]"].ToString()
						);
				}
				reader.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		/// <summary>
		/// This method was used to update the price for particular room no.
		/// </summary>
		/// <param name="building"></param>
		/// <param name="roomType"></param>
		/// <param name="roomNo"></param>
		private void UpdateRoomPrice(string building, string roomType, string roomNo)
		{
			try
			{
				con.Open();
				SqlCommand command = new SqlCommand();
				command.CommandText = "Update RoomDetails set Price = @Price where Building = @Building and [Room Type] = @RoomType and [Room No]=@RoomNo";
				command.CommandType = CommandType.Text;

				//command.Parameters.Add("@Price", SqlDbType.VarChar, 10).Value = price;
				//command.Parameters.Add("@Building", SqlDbType.VarChar, 20).Value = building;
				//command.Parameters.Add("@RoomType", SqlDbType.VarChar, 20).Value = roomType;
				//command.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNo;


				var result = command.ExecuteNonQuery();
				command.Dispose();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				con.Close();
			}
		}
	}
}
