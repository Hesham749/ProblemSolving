# Write your MySQL query statement below
select contest_id , round((count(r.user_id)*1.00 / (select count(*) from users)*1.00 )*100.00,2)  as percentage   from users as u join register as r 
on u.user_id = r.user_id 
group by contest_id 
order by percentage desc , contest_id 