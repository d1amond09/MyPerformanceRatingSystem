using System.ComponentModel;

namespace PerformanceRatingSystem.Application.Dtos;

public class DepartmentWithResultDto
{
	public Guid DepartmentId { get; set; }
    [DisplayName("���")]
    public string Name { get; set; }
    [DisplayName("���������")]
    public decimal Value { get; set; }

    [DisplayName("���")]
    public short Year { get; set; }

    [DisplayName("�������")]
    public byte Quarter { get; set; }
}

