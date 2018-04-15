import { Routes } from "@angular/router";

export const ROUTES: Routes = [
	{ path: "employee", loadChildren: "./views/employee/employee.module#EmployeeModule" },
	{ path: "", redirectTo: "employee", pathMatch: "full" },
	{ path: "**", redirectTo: "employee" }
];
