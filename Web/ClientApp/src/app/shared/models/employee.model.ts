import { TaxSalary } from "./tax-salary.model";

export class Employee {
	name: string;
	email: string;
	grossSalary: number;
	taxSalary = new TaxSalary();
}
