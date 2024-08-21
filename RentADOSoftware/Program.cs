

using RentADOSoftware.Core.DTOs;
using RentADOSoftware.Core.Entities;
using RentADOSoftware.Repository;
using RentADOSoftware.Service;

string connectionString = "Server=.\\SQLEXPRESS; Database=RentADONETSoftware; Trusted_Connection=true; TrustServerCertificate=true;";
var agentRepository = new AgentRepository(connectionString);
var agentService = new AgentService(agentRepository);

bool IsExit = true;

while (IsExit)
{
    Console.WriteLine("\n Press 1 : Add Agent \n Press 2 : Get All Agents Agent\n Press 3 : Update Agent\n Press 4 : Delete Agent\n Press 5 : Exit");
    string Choice = Console.ReadLine();

    switch (Choice)
    {
        case "1":
            Console.WriteLine("Enter Agent Name : ");
            string agentName = Console.ReadLine();

            var agentDTO = new AgentDTO
            {
                Name = agentName
            };

            await agentService.AddAgentAsync(agentDTO);

            Console.WriteLine("Agent added successfully.");
            break;

        case "2":
            Console.WriteLine("Here is List of all Agents : \n");
            var agents = await agentService.GetAllAgentAsync();

            foreach (var agent in agents)
            {
                Console.WriteLine($"Agent ID: {agent.AgentId}, Name: {agent.Name}");
            }
            break;

        case "3":
            break;
        case "4":
            Console.WriteLine("Here is List of all Agents : \n");

            var GetAllagents = await agentService.GetAllAgentAsync();

            foreach (var agent in GetAllagents)
            {
                Console.WriteLine($"Agent ID: {agent.AgentId}, Name: {agent.Name}");
            }

            Console.WriteLine("Enter Agent Id you want to delete record");
            int id = Convert.ToInt32(Console.ReadLine());

            await agentService.DeleteAgentAsync(id);

            Console.WriteLine($"Agent ID : {id} has been deleted successfully!.");

            break;
        case "5":
            IsExit = false;
            break;
        default:
            break;
    }
}

