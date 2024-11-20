using System.ComponentModel;

namespace PerformanceRatingSystem.Application.Dtos;

public class EmployeeWithResultDto
{
	public Guid EmployeeId { get; set; }
    [DisplayName("���")]
    public string FullName { get; set; }
    [DisplayName("���������")]
    public decimal Value { get; set; }

    [DisplayName("���")]
    public short Year { get; set; }

    [DisplayName("�������")]
    public byte Quarter { get; set; }
}

