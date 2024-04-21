export interface ReservationForm {
    carId: number;
    from: string;
    to: string;
    rentPlace: string;
    returnPlace: string;
    isFullAssurance: boolean;
    pay: 0 | 1;
    price: number;
}