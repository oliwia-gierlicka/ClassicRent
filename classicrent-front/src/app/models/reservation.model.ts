export interface Reservation {
    id: number;
    carId: number;
    clientId: number;
    employeeId: number;
    status: number;
    from: string;
    to: string;
    rentPlace: string;
    returnPlace: string;
    isFullAssurance: boolean;
    pay: number;
    price: number;
}