using Microsoft.Data.SqlClient;
using RentADOSoftware.Core.DTOs;
using RentADOSoftware.Core.Entities;
using RentADOSoftware.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentADOSoftware.Repository
{
    public class AgentRepository : IAgentRepository
    {

        public readonly string _connectionString;

        public AgentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task AddAgentAsync(AgentDTO agentDto)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var query = "INSERT INTO Agents (Name) Values (@name)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", agentDto.Name);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAgentAsync(int id)
        {
            var query = "DELETE FROM Agents WHERE AgentId = @Id";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(); 

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No agent found with the given ID.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task<AgentDTO> GetAgentByIdAsync(int id)
        {
            AgentDTO agent = null;

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(); // Open connection asynchronously

                    var query = "SELECT AgentId, Name FROM Agents WHERE AgentId = @Id";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                agent = new AgentDTO
                                {
                                    AgentId = reader.GetInt32(reader.GetOrdinal("AgentId")),
                                    Name = reader.GetString(reader.GetOrdinal("Name"))
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
            }
            catch (InvalidOperationException invalidOpEx)
            {
                Console.WriteLine($"Invalid Operation Error: {invalidOpEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }

            return agent;
        }

        public async Task<IEnumerable<AgentDTO>> GetAllAgentAsync()
        {
            var agents = new List<AgentDTO>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var query = "SELECT * FROM Agents";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var agent = new AgentDTO
                            {
                                AgentId = reader.GetInt32(reader.GetOrdinal("AgentId")),
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                            };

                            agents.Add(agent);
                        }
                    }
                }
            }
            return agents;
        }

        public Task UpdateAgentAsync(AgentDTO agentDto)
        {
            throw new NotImplementedException();
        }
    }
}
