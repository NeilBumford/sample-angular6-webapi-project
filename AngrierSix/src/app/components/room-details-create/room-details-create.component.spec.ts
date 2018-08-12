import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RoomDetailsCreateComponent } from './room-details-create.component';

describe('RoomDetailsCreateComponent', () => {
  let component: RoomDetailsCreateComponent;
  let fixture: ComponentFixture<RoomDetailsCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RoomDetailsCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RoomDetailsCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
