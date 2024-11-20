using System.ComponentModel;

namespace PerformanceRatingSystem.Application.Dtos;

public class AchievementDto 
{
	public Guid AchievementId { get; set; }
    [DisplayName("��������")]
    public string Description { get; set; }
    [DisplayName("���� ����������")]
    public DateOnly DateAchieved { get; set; }
	public Guid EmployeeId { get; set; }
    [DisplayName("���������")]
    public EmployeeDto Employee { get; set; }
}

