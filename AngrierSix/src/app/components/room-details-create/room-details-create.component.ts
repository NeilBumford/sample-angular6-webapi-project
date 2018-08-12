import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormControl, FormGroupDirective, FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
//import { first } from 'rxjs/operators';
import { RoomDetailsService } from '../../services/room-details.service';

@Component({
  //selector: 'app-room-details-create',
  templateUrl: './room-details-create.component.html',
  styleUrls: ['./room-details-create.component.css']
})

export class RoomDetailsCreateComponent implements OnInit {

  roomForm: FormGroup;
  length: number = null;
  width: number = null;
  height: number = null;
  loading = false;
  submitted = false;

  constructor(
    private formBuilder: FormBuilder,
    private router: Router,
    private roomDetailsService: RoomDetailsService
  ) { }

  ngOnInit() {
    this.roomForm = this.formBuilder.group({
      /*
      length: [null, Validators.required, Validators.min(1)],
      width: [null, Validators.required, Validators.min(1)],
      height: [null, Validators.required, Validators.min(1)]
      */

      length: [null],
      width: [null],
      height: [null]
    });
  }

  get f() { return this.roomForm.controls; }


  onSubmit(form: NgForm) {

    this.submitted = true;
    // stop here if form is invalid

    if (this.roomForm.invalid) {
      return;
    }
    this.loading = true;

    this.roomDetailsService.calculate(this.roomForm.value)
      //.pipe(first())
      .subscribe(
        data => {
          //this.alertService.success('Registration successful', true);
          console.log(data);
          this.router.navigate(['/room-details']);
        },
        error => {
          //this.alertService.error(error);
          this.loading = false;
        });

  }

}
