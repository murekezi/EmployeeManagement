import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { SharedModule } from "../../shared/shared.module";
import { EmployeeComponent } from "./employee.component";

const routes: Routes = [
	{ path: "", component: EmployeeComponent }
];

@NgModule({
	declarations: [EmployeeComponent],
	imports: [
		RouterModule.forChild(routes),
		SharedModule
	]
})
export class EmployeeModule { }
