import { Component, Input, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ModalDismissReasons, NgbActiveModal, NgbModal, NgbModalOptions } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { first } from 'rxjs/operators';
import { IngredientsService } from 'src/app/services/ingredients.service';
import { MeasureUnitService } from 'src/app/services/measure-unit.service';

@Component({
  selector: 'app-add-ingredients',
  templateUrl: './add-ingredients.component.html',
  styleUrls: ['./add-ingredients.component.css']
})
export class AddIngredientsComponent implements OnInit {
  @Input() fromParent;
  ingredientForm: FormGroup;
  measureUnits:any=[];
  closeResult: string;
  modalOptions:NgbModalOptions;
  constructor(private measureUnitService: MeasureUnitService, private ingredientService: IngredientsService,
    private router: Router, private toastr: ToastrService,private modalService: NgbModal, public activeModal: NgbActiveModal) { }

  ngOnInit() {
    this.getMeasureUnit();
    this.initializeForm();
  }

  initializeForm(){
    this.ingredientForm=new FormGroup({
      name: new FormControl("", Validators.required),
      unitPrice: new FormControl("", Validators.required),
      unitQuantity: new FormControl("", Validators.required),
      measureUnit_Id: new FormControl("", Validators.required),
    })
  }

  get form() {
    return this.ingredientForm.controls;
  }

  closeModal(sendData) {
    this.activeModal.close(sendData);
  }

  onSubmit(){
    if (this.ingredientForm.invalid) {
      return;
    }
 
     this.ingredientService.save(this.ingredientForm.value).pipe(first()).subscribe(
       (data)=>{
        this.toastr.success("Data is successfully saved!", "Success!");
        this.closeModal(data);
       },
        (error) => {
        this.toastr.error("Something went wrong", "Error!");
       }
     )
  }

  getMeasureUnit(){
  
    this.measureUnitService.get().pipe(first()).subscribe(
      (response:any)=>{
       this.measureUnits=response;
      }
    )
  }

}
