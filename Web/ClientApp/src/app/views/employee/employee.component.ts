import { Component } from "@angular/core";
import { FormBuilder, FormGroup } from "@angular/forms";

import { EmployeeService } from "../../shared/services/employee.service";
import { Employee } from "../../shared/models/employee.model";

@Component({ selector: "app-employee", templateUrl: "./employee.component.html" })
export class EmployeeComponent {
	employee: Employee;
	form: FormGroup;

	constructor(private readonly formBuilder: FormBuilder,
		private readonly employeeService: EmployeeService) {
		this.createForm();
	}

	createForm() {
		this.form = this.formBuilder.group({
			name: [],
			email: [],
			grossSalary: []
		});
	}

	onSubmit(form: any) {
		this.employeeService
			.calculateTaxSalary(form.value)
			.subscribe((employee) => { this.employee = employee; });
	}
}
