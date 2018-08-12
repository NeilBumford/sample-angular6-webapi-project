import { TestBed, inject } from '@angular/core/testing';

import { RoomDetailsService } from './room-details.service';

describe('RoomDetailsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RoomDetailsService]
    });
  });

  it('should be created', inject([RoomDetailsService], (service: RoomDetailsService) => {
    expect(service).toBeTruthy();
  }));
});
