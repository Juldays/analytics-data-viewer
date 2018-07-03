import * as axios from "axios";

const URL_PREFIX = "";

export function adminAnalytics_getByDay() {
  return axios.get(URL_PREFIX + "/api/admin-analytics/day");
}

export function adminAnalytics_getByWeek() {
  return axios.get(URL_PREFIX + "/api/admin-analytics/week");
}

export function adminAnalytics_getByMonth() {
  return axios.get(URL_PREFIX + "/api/admin-analytics/month");
}

export function adminAnalytics_getBy6Months() {
  return axios.get(URL_PREFIX + "/api/admin-analytics/6months");
}

export function adminAnalytics_getByYear() {
  return axios.get(URL_PREFIX + "/api/admin-analytics/year");
}