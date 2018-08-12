import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RoomDetailsDetailComponent } from './room-details-detail.component';

describe('RoomDetailsDetailComponent', () => {
  let component: RoomDetailsDetailComponent;
  let fixture: ComponentFixture<RoomDetailsDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RoomDetailsDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RoomDetailsDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
