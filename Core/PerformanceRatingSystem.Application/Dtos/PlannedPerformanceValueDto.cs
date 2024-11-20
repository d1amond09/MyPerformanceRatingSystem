using System.ComponentModel;

namespace PerformanceRatingSystem.Application.Dtos;

public class PlannedPerformanceValueDto 
{
	public Guid PlanId { get; set; }
    [DisplayName("��� ����������")]
    public string? IndicatorType { get; set; }

    [DisplayName("���������")]
    public decimal Value { get; set; }

    [DisplayName("���")]
    public short Year { get; set; }

    [DisplayName("�������")]
    public byte Quarter { get; set; }

    [DisplayName("����������")]
	public DepartmentPerformanceIndicatorDto Indicator { get; set; }
    public Guid IndicatorId { get; set; }
}

