using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
	class LinqPractice
	{
		public static void GroupBy()
		{
			List<List<Pet>> petsList = new List<List<Pet>>() {
				new List<Pet>
				{
					new Pet { Name="Barley", Age=8.3 },
					new Pet { Name="Boots", Age=4.9 },
					new Pet { Name="Whiskers", Age=1.5 },
					new Pet { Name="Baisy", Age=4.3 }
				},
				new List<Pet>
				{
					new Pet { Name="Farley", Age=8.3 },
					new Pet { Name="Fix", Age=4.9 },
					new Pet { Name="Fhiskers", Age=1.5 },
					new Pet { Name="Faisy", Age=4.3 }
				}
			};

			var users = new List<UserDto>() {
				new UserDto
				{
					UserId = 1,
					Clients = new List<ClientDto> {
						new ClientDto { SchoolTypeId = 1, ClientFranchiseeId = 1 },
						new ClientDto { SchoolTypeId = 2, ClientFranchiseeId = 2 } }
				},
				new UserDto
				{
					UserId = 2,
					Clients = new List<ClientDto> {
						new ClientDto { SchoolTypeId = 2, ClientFranchiseeId = 1 },
						new ClientDto { SchoolTypeId = 2, ClientFranchiseeId = 2 },
						new ClientDto { SchoolTypeId = 3, ClientFranchiseeId = 1 } }
				},

				new UserDto
				{
					UserId = 2,
					Clients = new List<ClientDto> {
						new ClientDto { SchoolTypeId = 2, ClientFranchiseeId = 1 },
						new ClientDto { SchoolTypeId = 2, ClientFranchiseeId = 2 },
						new ClientDto { SchoolTypeId = 3, ClientFranchiseeId = 1 } }
				}
			};

			var sameFranchiseeDiffTypeSchools = users
						.Where(u => u.Clients
							.GroupBy(c => c.ClientFranchiseeId)
							.Select(g => g.Select(c => c).GroupBy(g => g.SchoolTypeId)).Where(g => g.Count() > 1).Any());

			var sameFranchiseeSameTypeSchool = users
						.Where(u => u.Clients
							.GroupBy(c => new {
								schooltypeId = c.SchoolTypeId,
								franchiseeId = c.ClientFranchiseeId
							})
							.Any(g => g.Count() > 1));

			var diffFranchDiffSchoolTypes = users
						.Where(u => u.Clients
							.GroupBy(c => new {
								schooltypeId = c.SchoolTypeId,
								franchiseeId = c.ClientFranchiseeId
							}).Count() > 1);

			var diffFranchSameSchoolTypes = users
						.Where(u => u.Clients
							.GroupBy(c => new {
								schooltypeId = c.SchoolTypeId
							}).Select(g => g.Select(c => c).GroupBy(g => g.ClientFranchiseeId)).Where(g => g.Count() > 1).Any());

			var query3 = petsList.Select(p => p.GroupBy(p => p.Name.First(),
				(age, pets) => new { age, count = pets.Count() })).Where(g => g.Count() > 1);
		}
	}

	class Pet
	{
		public string Name { get; set; }
		public double Age { get; set; }
	}

	class UserDto
	{
		public UserDto()
		{

		}

		public UserDto(ClientDto clientDto)
		{
			UserId = clientDto.UserId;
			Clients.Add(clientDto);
		}

		public int UserId { get; set; }
		public List<ClientDto> Clients { get; set; } = new List<ClientDto>();
	}

	class ClientDto
	{
		public ClientDto()
		{

		}

		public int? ClientFranchiseeId { get; set; }
		public int SchoolFranchiseeId { get; set; }
		public int Id { get; set; }
		public int UserId { get; set; }
		public List<SchoolDto> Schools { get; set; } = new List<SchoolDto>();
		public int SchoolId { get; set; }
		public int SchoolTypeId { get; set; }
	}

	class SchoolDto
	{
		public int Id { get; set; }
		public int SchoolTypeId { get; set; }
	}
}
