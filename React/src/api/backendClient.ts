import Gap from "../models/GapGeneral"

export const getGeneralByYear = async (year?: number): Promise<Gap[]> => {
    const response = await fetch(`http://localhost:5287/gender-gap/general/${year}`)
    const data: Gap[] = await response.json();
    return data
}