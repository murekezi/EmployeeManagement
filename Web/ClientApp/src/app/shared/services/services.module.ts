import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";

import { EmployeeService } from "./employee.service";

@NgModule({
	imports: [
		HttpClientModule
	],
	providers: [
		EmployeeService
	]
})
export class ServicesModule { }
