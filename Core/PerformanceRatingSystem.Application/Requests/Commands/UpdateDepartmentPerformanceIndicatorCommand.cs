﻿using MediatR;
using PerformanceRatingSystem.Application.Dtos;

namespace PerformanceRatingSystem.Application.Requests.Commands;

public record UpdateDepartmentPerformanceIndicatorCommand(DepartmentPerformanceIndicatorForUpdateDto DepartmentPerformanceIndicator) : IRequest<bool>;
