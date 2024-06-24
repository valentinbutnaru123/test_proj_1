﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.IssueDTO
{
	public class GetIssuesDTO
	{
		public int IdPos { get; set; }
		public PosEntity Pos { get; set; }//+
		public string PosName { get; set; }
		public int IdType { get; set; }
		public IssuesTypeEntity IssuesType { get; set; }
		public int IdStatus { get; set; }
		public StatusEntity Statuses { get; set; } //-
		public int IdUserCreated { get; set; }
		public UserEntity User { get; set; }//+
		public int IdUserType { get; set; }
		public UserTypeEntity UserType { get; set; }//+
		public long AssignedDate { get; set; }
		public long CreationDate { get; set; }
		public int AssignedToId { get; set; }
	}
}
