import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs/Observable";

import { Employee } from "../models/employee.model";

@Injectable()
export class EmployeeService {
	constructor(private readonly http: HttpClient) { }

	calculateTaxSalary(employee: Employee): Observable<Employee> {
		return this.http.post<Employee>("EmployeeService/CalculateTaxSalary", employee);
	}
}