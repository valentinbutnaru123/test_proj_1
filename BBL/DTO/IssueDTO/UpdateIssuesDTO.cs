﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.IssueDTO
{
	public class UpdateIssuesDTO
	{
		public int IdPos { get; set; }
		public PosEntity Pos { get; set; }//+
		public int IdType { get; set; }
		public IssuesTypeEntity IssuesType { get; set; }
		public int IdSubType { get; set; }
		public int IdProblem { get; set; }
		public string Priority { get; set; }
		public int IdStatus { get; set; }
		public StatusEntity Statuses { get; set; } //-
		public string Memo { get; set; }
		public int IdUserCreated { get; set; }
		public UserEntity User { get; set; }//+
		public int IdUserType { get; set; }
		public UserTypeEntity UserType { get; set; }//+
		public string Description { get; set; }
		public long AssignedDate { get; set; }
		public long CreationDate { get; set; }
		public long ModifDate { get; set; }
		public string Solotion { get; set; }
	}
}
