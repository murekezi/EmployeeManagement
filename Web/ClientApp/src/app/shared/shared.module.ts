import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { ServicesModule } from "./services/services.module";

@NgModule({
	exports: [
		CommonModule,
		FormsModule,
		ReactiveFormsModule,
		ServicesModule
	],
	imports: [
		CommonModule,
		FormsModule,
		ReactiveFormsModule,
		ServicesModule
	]
})
export class SharedModule { }
